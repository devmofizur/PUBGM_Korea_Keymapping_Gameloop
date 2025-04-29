using System;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using Keymapping.Properties;
using System.Linq;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Keymapping
{
    public partial class Keymapping : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        public Keymapping()
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

        String UI = (String) Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Tencent\MobileGamePC\UI", "InstallPath", null);
        private readonly string hostsFilePath = @"C:\Windows\System32\drivers\etc\hosts";

        private void CONTROL_GL_TW_VNG_Click(object sender, EventArgs e)
        {

            string[] filePaths = new string[]
        {
            @"" + UI + "\\DefaultKeyMapping.xml",
            @"" + UI + "\\GameSidebar.xml",
            @"" + UI + "\\AEngine.dll",
            @"" + UI + "\\smk.conf",
            @"" + UI + "\\translate.conf",
        };

            foreach (string filePath in filePaths)
            {
                try
                {
                    FileInfo fileInfo = new FileInfo(filePath);
                    fileInfo.IsReadOnly = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Access Denied");
                }
            }

            try
            {
                if (!File.Exists(hostsFilePath))
                {
                    MessageBox.Show("Hosts file not found.");
                    return;
                }

                // Lines to remove
                string[] linesToRemove = {
                    "127.0.0.1 conf.syzs.qq.com",
                    "127.0.0.1 pm.myapp.com",
                    "127.0.0.1 unifiedaccess.gameloop.com"
                };

                // Read all lines from hosts file
                var lines = File.ReadAllLines(hostsFilePath);

                // Filter out lines to remove
                var updatedLines = lines.Where(line => !linesToRemove.Contains(line.Trim())).ToArray();

                // Write the filtered lines back to the hosts file
                File.WriteAllLines(hostsFilePath, updatedLines);

            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Access denied. Please run the application as an administrator.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

            File.WriteAllBytes(UI + "\\DefaultKeyMapping.xml", Resources.DefaultKeyMappin);
            File.WriteAllBytes(UI + "\\AEngine.dll", Resources.AEngin); // PUBG Resoulution of Gameloop Setting
            File.WriteAllBytes(UI + "\\GameSidebar.xml", Resources.GameSideba);
            File.WriteAllBytes(UI + "\\smk.conf", Resources.sm);
            File.WriteAllBytes(UI + "\\translate.conf", Resources.translat);

            status.Image = Resources.GL_TW_VNG_SUCCESS;
        }

        private void CONTROL_KR_Click(object sender, EventArgs e)
        {

            string[] filePaths = new string[]
            {
                UI + "\\DefaultKeyMapping.xml",
                UI + "\\GameSidebar.xml",
                UI + "\\AEngine.dll",
                UI + "\\smk.conf",
                UI + "\\translate.conf",
            };

            byte[][] fileContents = new byte[][]
            {
                Resources.DefaultKeyMapping,
                Resources.GameSidebar,
                Resources.AEngine,
                Resources.smk,
                Resources.translate
            };

            for (int i = 0; i < filePaths.Length; i++)
            {
                string filePath = filePaths[i];
                byte[] content = fileContents[i];

                FileInfo fileInfo = new FileInfo(filePath);

                if (fileInfo.Exists && fileInfo.IsReadOnly)
                    continue;

                try
                {
                    File.WriteAllBytes(filePath, content);
                    fileInfo = new FileInfo(filePath);
                    fileInfo.IsReadOnly = true;
                }
                catch (Exception ex)
                {
                }
            }


            try
            {
                if (!File.Exists(hostsFilePath))
                {
                    MessageBox.Show("Hosts file not found.");
                    return;
                }

                string[] linesToAdd = {
                    "127.0.0.1 conf.syzs.qq.com",
                    "127.0.0.1 pm.myapp.com",
                    "127.0.0.1 unifiedaccess.gameloop.com"
                };

                using (StreamWriter writer = new StreamWriter(hostsFilePath, true))
                {
                    foreach (string line in linesToAdd)
                    {
                        writer.WriteLine(line);
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Access denied. Hosts file corrupted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

            Process.Start("https://discord.gg/DqzbJbMAms");

            
            status.Image = Resources.KR_SUCCESS;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }
    }
}
