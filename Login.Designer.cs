namespace Keymapping
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.license = new System.Windows.Forms.TextBox();
            this.Login_BTN = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Login_BTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // license
            // 
            this.license.BackColor = System.Drawing.Color.Black;
            this.license.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.license.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.license.ForeColor = System.Drawing.Color.White;
            this.license.Location = new System.Drawing.Point(60, 172);
            this.license.Name = "license";
            this.license.Size = new System.Drawing.Size(141, 13);
            this.license.TabIndex = 0;
            this.license.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Login_BTN
            // 
            this.Login_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Login_BTN.Image")));
            this.Login_BTN.Location = new System.Drawing.Point(77, 219);
            this.Login_BTN.Name = "Login_BTN";
            this.Login_BTN.Size = new System.Drawing.Size(109, 22);
            this.Login_BTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Login_BTN.TabIndex = 7;
            this.Login_BTN.TabStop = false;
            this.Login_BTN.Click += new System.EventHandler(this.Login_BTN_Click);
            // 
            // exit
            // 
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(56, 263);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(142, 24);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit.TabIndex = 8;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Login_BTN);
            this.Controls.Add(this.license);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Login_BTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox license;
        private System.Windows.Forms.PictureBox Login_BTN;
        private System.Windows.Forms.PictureBox exit;
    }
}