namespace AnimationSprite2D
{
    partial class Sprite2D_UserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuSelection = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemSpeedUp = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSpeedDown = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.itemZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.itemPause = new System.Windows.Forms.ToolStripMenuItem();
            this.itemResume = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.itemChangeImage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.itemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuSelection
            // 
            this.menuSelection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemSpeedUp,
            this.itemSpeedDown,
            this.toolStripSeparator1,
            this.itemZoomIn,
            this.itemZoomOut,
            this.toolStripSeparator2,
            this.itemPause,
            this.itemResume,
            this.toolStripSeparator3,
            this.itemChangeImage,
            this.toolStripSeparator4,
            this.itemExit});
            this.menuSelection.Name = "menuSelection";
            this.menuSelection.Size = new System.Drawing.Size(180, 204);
            this.menuSelection.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.menuSelection_Closed);
            this.menuSelection.Opened += new System.EventHandler(this.menuSelection_Opened);
            this.menuSelection.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuSelection_ItemClicked);
            // 
            // itemSpeedUp
            // 
            this.itemSpeedUp.Name = "itemSpeedUp";
            this.itemSpeedUp.Size = new System.Drawing.Size(179, 22);
            this.itemSpeedUp.Text = "Speed up - \"+\"";
            // 
            // itemSpeedDown
            // 
            this.itemSpeedDown.Name = "itemSpeedDown";
            this.itemSpeedDown.Size = new System.Drawing.Size(179, 22);
            this.itemSpeedDown.Text = "Speed down - \"-\"";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(176, 6);
            // 
            // itemZoomIn
            // 
            this.itemZoomIn.Name = "itemZoomIn";
            this.itemZoomIn.Size = new System.Drawing.Size(179, 22);
            this.itemZoomIn.Text = "Zoom in - \"[\"";
            // 
            // itemZoomOut
            // 
            this.itemZoomOut.Name = "itemZoomOut";
            this.itemZoomOut.Size = new System.Drawing.Size(179, 22);
            this.itemZoomOut.Text = "Zoom out - \"]\"";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(176, 6);
            // 
            // itemPause
            // 
            this.itemPause.Name = "itemPause";
            this.itemPause.Size = new System.Drawing.Size(179, 22);
            this.itemPause.Text = "Pause - \"S\"";
            // 
            // itemResume
            // 
            this.itemResume.Name = "itemResume";
            this.itemResume.Size = new System.Drawing.Size(179, 22);
            this.itemResume.Text = "Resume - \"P\"";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(176, 6);
            // 
            // itemChangeImage
            // 
            this.itemChangeImage.Name = "itemChangeImage";
            this.itemChangeImage.Size = new System.Drawing.Size(179, 22);
            this.itemChangeImage.Text = "Change Image - \"B\"";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(176, 6);
            // 
            // itemExit
            // 
            this.itemExit.Name = "itemExit";
            this.itemExit.Size = new System.Drawing.Size(179, 22);
            this.itemExit.Text = "Exit - \"ESC\"";
            // 
            // Sprite2D_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.Name = "Sprite2D_UserControl";
            this.Size = new System.Drawing.Size(211, 225);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Sprite2D_UserControl_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Sprite2D_UserControl_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Sprite2D_UserControl_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Sprite2D_UserControl_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sprite2D_UserControl_MouseUp);
            this.menuSelection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip menuSelection;
        private System.Windows.Forms.ToolStripMenuItem itemSpeedUp;
        private System.Windows.Forms.ToolStripMenuItem itemSpeedDown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem itemZoomIn;
        private System.Windows.Forms.ToolStripMenuItem itemZoomOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem itemPause;
        private System.Windows.Forms.ToolStripMenuItem itemResume;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem itemChangeImage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem itemExit;
    }
}
