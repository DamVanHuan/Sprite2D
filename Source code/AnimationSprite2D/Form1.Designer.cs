namespace AnimationSprite2D
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sprite2D_UserControl1 = new AnimationSprite2D.Sprite2D_UserControl();
            this.SuspendLayout();
            // 
            // sprite2D_UserControl1
            // 
            this.sprite2D_UserControl1.BackColor = System.Drawing.Color.Black;
            this.sprite2D_UserControl1.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.sprite2D_UserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sprite2D_UserControl1.Location = new System.Drawing.Point(0, 0);
            this.sprite2D_UserControl1.Name = "sprite2D_UserControl1";
            this.sprite2D_UserControl1.Size = new System.Drawing.Size(374, 296);
            this.sprite2D_UserControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(374, 296);
            this.ControlBox = false;
            this.Controls.Add(this.sprite2D_UserControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Sprite2D_UserControl sprite2D_UserControl1;








    }
}

