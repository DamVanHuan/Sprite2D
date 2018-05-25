using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimationSprite2D
{
    public partial class Form1 : Form
    {
        private NotifyIcon notifyIcon;

        public Form1()
        {
            InitializeComponent();

            this.TransparencyKey = Color.Transparent;

            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = Properties.Resources.valak;
            notifyIcon.Text = "Sprite 2D - 1512190";
            notifyIcon.Visible = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.notifyIcon.Visible = false;
        }
    }
}
