using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Resources;
using System.Collections;

namespace AnimationSprite2D
{
    public enum SelectedItemContextMenuStrip
    {
        SpeedUp, SpeedDown,
        ZoomIn, ZoomOut,
        Pause, Resume,
        ChangeImage,
        Exit
    }

    public partial class Sprite2D_UserControl : UserControl
    {
        private Sprite2D player;
        private int _x, _y;
        bool isClickOnImage = false;
        private StateAction prevAction;
        private int tempX = 0, tempY = 0;//chenh lech X, Y khi kheo tha
        private List<Bitmap> _ListImages;
        private int _IndexImage;

        public Sprite2D_UserControl()
        {
            InitializeComponent();

            player = new Sprite2D();

            int maxX = Screen.PrimaryScreen.WorkingArea.Width;
            int maxY = Screen.PrimaryScreen.WorkingArea.Height;
            _x = maxX / 2 - 32;
            _y = maxY / 2 - 48;

            _IndexImage = 0;
            _ListImages = new List<Bitmap>();
            LoadImages();

            setPlayer(_x, _y, 0, 0, StateAction.Down, StateAction.Standing,
                _ListImages[_IndexImage].Width / 4, _ListImages[_IndexImage].Height / 4, maxX, maxY, 0, 0);
        }

        private void LoadImages()
        {
            ResourceSet resourceSet = Properties.Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
            
            foreach (DictionaryEntry entry in resourceSet)
            {
                object resource = entry.Value;

                if (resource.GetType() == typeof(System.Drawing.Bitmap))
                {
                    Bitmap oj = (Bitmap)Properties.Resources.ResourceManager.GetObject(entry.Key.ToString());
                    _ListImages.Add(new Bitmap(oj));
                }
            }
        }

        private void setPlayer(int x, int y, int dx, int dy, StateAction direction, StateAction action, 
            int width, int height, int maxX, int maxY, int indexCol, int indexRow)
        {
            player.X = x;
            player.Y = y;

            player.Dx = dx;
            player.Dy = dy;

            player.Direction = direction;
            player.Action = action;

            player.Width = width;
            player.Height = height;

            player.MaxX = maxX;
            player.MaxY = maxY;

            player.IndexColumn = indexCol;
            player.IndexRow = indexRow;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            BufferedGraphicsContext doublebuffer = BufferedGraphicsManager.Current;
            BufferedGraphics buffer = doublebuffer.Allocate(g, this.ClientRectangle);

            buffer.Graphics.Clear(Color.White);
            player.movePlayer(buffer, _ListImages[_IndexImage]);
            buffer.Render(g);
        }

        private void Sprite2D_UserControl_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    player.Action = StateAction.Left;
                    break;

                case Keys.Right:
                    player.Action = StateAction.Right;
                    break;

                case Keys.Down:
                    player.Action = StateAction.Down;
                    break;

                case Keys.Up:
                    player.Action = StateAction.Up;
                    break;

                case Keys.Add:
                    ChangedAction(SelectedItemContextMenuStrip.SpeedUp);
                    break;

                case Keys.Subtract:
                    ChangedAction(SelectedItemContextMenuStrip.SpeedDown);
                    break;

                case Keys.S: //pause
                    ChangedAction(SelectedItemContextMenuStrip.Pause);
                    break;

                case Keys.P: //resume
                    ChangedAction(SelectedItemContextMenuStrip.Resume);
                    break;

                case Keys.B: //change other image
                    ChangedAction(SelectedItemContextMenuStrip.ChangeImage);
                    break;

                case Keys.Escape:
                    ChangedAction(SelectedItemContextMenuStrip.Exit);
                    break;

                default:
                    if (e.KeyValue == 219)// [ = 219, define maxZoom = 17
                    {
                        ChangedAction(SelectedItemContextMenuStrip.ZoomIn);
                    }

                    if (e.KeyValue == 221) // ] = 221
                    {
                        ChangedAction(SelectedItemContextMenuStrip.ZoomOut);
                    }
                    break;
            }//end of switch(e.KeyCode)
        }

        private void ChangeImage()
        {
            int countImages = _ListImages.Count;

            if (_IndexImage < countImages - 1)
            {
                _IndexImage++;
            }
            else _IndexImage = 0;

            player.Width = _ListImages[_IndexImage].Width / 4;
            player.Height = _ListImages[_IndexImage].Height / 4;
        }

        private void Sprite2D_UserControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && isClickOnImage)
            {
                player.X = e.X - tempX;
                player.Y = e.Y - tempY;

                isClickOnImage = false;
                player.Action = prevAction;
            }
        }

        private void Sprite2D_UserControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                prevAction = player.Action;

                if (prevAction != StateAction.Standing)
                {
                    player.Action = StateAction.Standing;
                }

                isClickOnImage = true;

                tempX = e.X - player.X;
                tempY = e.Y - player.Y;
            }
        }

        private void Sprite2D_UserControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (isClickOnImage)
            {
                player.X = e.X - tempX;
                player.Y = e.Y - tempY;
            }
        }

        private void Sprite2D_UserControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                menuSelection.Show(player.X + player.Width * player.Zoom, player.Y);
            }
        }

        private void menuSelection_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == itemSpeedUp)
            {
                ChangedAction(SelectedItemContextMenuStrip.SpeedUp);
                return;
            }

            if (e.ClickedItem == itemSpeedDown)
            {
                ChangedAction(SelectedItemContextMenuStrip.SpeedDown);
                return;
            }

            if (e.ClickedItem == itemZoomIn)
            {
                ChangedAction(SelectedItemContextMenuStrip.ZoomIn);
                return;
            }

            if (e.ClickedItem == itemZoomOut)
            {
                ChangedAction(SelectedItemContextMenuStrip.ZoomOut);
                return;
            }

            if (e.ClickedItem == itemChangeImage)
            {
                ChangedAction(SelectedItemContextMenuStrip.ChangeImage);
                return;
            }

            if (e.ClickedItem == itemPause)
            {
                ChangedAction(SelectedItemContextMenuStrip.Pause);
                return;
            }

            if (e.ClickedItem == itemResume)
            {
                ChangedAction(SelectedItemContextMenuStrip.Resume);
                return;
            }

            if (e.ClickedItem == itemExit)
            {
                ChangedAction(SelectedItemContextMenuStrip.Exit);
                return;
            }
        }

        private void ChangedAction(SelectedItemContextMenuStrip item)
        {
            switch (item)
            {
                case SelectedItemContextMenuStrip.SpeedUp:
                    timer1.Interval = (timer1.Interval - 10 > 0 ? timer1.Interval - 10 : timer1.Interval);
                    break;

                case SelectedItemContextMenuStrip.SpeedDown:
                    if (timer1.Interval < 1000)
                    {
                        timer1.Interval += 10;
                    }
                    break;

                case SelectedItemContextMenuStrip.ZoomIn:
                    if  (player.Zoom < 17)
                    {
                        ++player.Zoom;
                    }
                    break;

                case SelectedItemContextMenuStrip.ZoomOut:
                    if (player.Zoom > 1)
                    {
                        --player.Zoom;
                    }
                    break;

                case SelectedItemContextMenuStrip.Pause:
                    player.Action = StateAction.Standing;
                    break;

                case SelectedItemContextMenuStrip.Resume:
                    player.Action = player.Direction;
                    break;

                case SelectedItemContextMenuStrip.ChangeImage:
                    ChangeImage();
                    break;

                case SelectedItemContextMenuStrip.Exit:
                    Application.Exit();
                    break;

                default:
                    break;
            }
        }

        private void menuSelection_Opened(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void menuSelection_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            timer1.Enabled = true;
        }
    }   
}
