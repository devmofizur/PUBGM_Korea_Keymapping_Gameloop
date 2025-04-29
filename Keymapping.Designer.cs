namespace Keymapping
{
    partial class Keymapping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Keymapping));
            this.CONTROL_GL_TW_VNG = new System.Windows.Forms.PictureBox();
            this.CONTROL_KR = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.status = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CONTROL_GL_TW_VNG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTROL_KR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.status)).BeginInit();
            this.SuspendLayout();
            // 
            // CONTROL_GL_TW_VNG
            // 
            this.CONTROL_GL_TW_VNG.Image = ((System.Drawing.Image)(resources.GetObject("CONTROL_GL_TW_VNG.Image")));
            this.CONTROL_GL_TW_VNG.Location = new System.Drawing.Point(51, 194);
            this.CONTROL_GL_TW_VNG.Name = "CONTROL_GL_TW_VNG";
            this.CONTROL_GL_TW_VNG.Size = new System.Drawing.Size(141, 24);
            this.CONTROL_GL_TW_VNG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CONTROL_GL_TW_VNG.TabIndex = 2;
            this.CONTROL_GL_TW_VNG.TabStop = false;
            this.CONTROL_GL_TW_VNG.Click += new System.EventHandler(this.CONTROL_GL_TW_VNG_Click);
            // 
            // CONTROL_KR
            // 
            this.CONTROL_KR.Image = ((System.Drawing.Image)(resources.GetObject("CONTROL_KR.Image")));
            this.CONTROL_KR.Location = new System.Drawing.Point(51, 148);
            this.CONTROL_KR.Name = "CONTROL_KR";
            this.CONTROL_KR.Size = new System.Drawing.Size(141, 24);
            this.CONTROL_KR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CONTROL_KR.TabIndex = 3;
            this.CONTROL_KR.TabStop = false;
            this.CONTROL_KR.Click += new System.EventHandler(this.CONTROL_KR_Click);
            // 
            // exit
            // 
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(51, 287);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(142, 24);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit.TabIndex = 9;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(51, 240);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(141, 24);
            this.status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.status.TabIndex = 10;
            this.status.TabStop = false;
            // 
            // Keymapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.status);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.CONTROL_KR);
            this.Controls.Add(this.CONTROL_GL_TW_VNG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Keymapping";
            this.Text = "Keymapping 3.7";
            ((System.ComponentModel.ISupportInitialize)(this.CONTROL_GL_TW_VNG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTROL_KR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.status)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox CONTROL_GL_TW_VNG;
        private System.Windows.Forms.PictureBox CONTROL_KR;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox status;
    }
}

