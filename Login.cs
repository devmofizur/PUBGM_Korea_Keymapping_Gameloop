using KeyAuth;
using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using Keymapping.Properties;
using System.Runtime.InteropServices;

namespace Keymapping
{

    public partial class Login : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;


        public static api KeyAuthApp = new api(
    name: "Keymapping", // Application Name
    ownerid: "gvqYzBJJvK", // Owner ID
    secret: "214c88f96940adce6cb16e74da6bca74c8c4e95f07c5ad3ebf17eb8b89e47972", // Application Secret
    version: "3.71" // Application Version /*
                   //path: @"Your_Path_Here" // (OPTIONAL) see tutorial here https://www.youtube.com/watch?v=I9rxt821gMk&t=1s
);

        public Login()
        {
            InitializeComponent();
            this.FormClosing += MainForm_FormClosing;

            this.FormBorderStyle = FormBorderStyle.None;
            this.MouseDown += MyForm_MouseDown;
        }

        private void MyForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }


        static string random_string()
        {
            string str = null;

            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                str += Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))).ToString();
            }
            return str;

        }

        private void Login_Load(object sender, EventArgs e)
        {
            license.Text = Settings.Default.username;
            KeyAuthApp.init();

            if (!KeyAuthApp.response.success)
            {
                MessageBox.Show(KeyAuthApp.response.message);
                Environment.Exit(0);
            }

            #region Auto Update
            if (KeyAuthApp.response.message == "invalidver")
            {
                if (!string.IsNullOrEmpty(KeyAuthApp.app_data.downloadLink))
                {
                    DialogResult dialogResult = MessageBox.Show("Yes to open file in browser\nNo to download file automatically", "Auto update", MessageBoxButtons.YesNo);
                    switch (dialogResult)
                    {
                        case DialogResult.Yes:
                            Process.Start(KeyAuthApp.app_data.downloadLink);
                            Environment.Exit(0);
                            break;
                        case DialogResult.No:
                            WebClient webClient = new WebClient();
                            string destFile = Application.ExecutablePath;

                            string rand = random_string();

                            destFile = destFile.Replace(".exe", $"-{rand}.exe");
                            webClient.DownloadFile(KeyAuthApp.app_data.downloadLink, destFile);

                            Process.Start(destFile);
                            Process.Start(new ProcessStartInfo()
                            {
                                Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
                                WindowStyle = ProcessWindowStyle.Hidden,
                                CreateNoWindow = true,
                                FileName = "cmd.exe"
                            });
                            Environment.Exit(0);

                            break;
                        default:
                            MessageBox.Show("Invalid option");
                            Environment.Exit(0);
                            break;
                    }
                }
                MessageBox.Show("Version of this program does not match the one online. Furthermore, the download link online isn't set. You will need to manually obtain the download link from the developer");

                
                Environment.Exit(0);
                #endregion
            }

            license.TabStop = false;

        }

        private void Login_BTN_Click(object sender, EventArgs e)
        {
            KeyAuthApp.license(license.Text);
            if (KeyAuthApp.response.success)
            {
                Settings.Default["username"] = license.Text;
                Settings.Default.Save();

                Keymapping main = new Keymapping();
                main.Show();
                main.StartPosition = FormStartPosition.Manual;
                main.Location = this.Location;
                this.Hide();
            }
            else
                MessageBox.Show("Status: " + KeyAuthApp.response.message);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }
    }
}