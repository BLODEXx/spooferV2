using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyAuth;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace VALORANT_CUSTOM
{
    public partial class Form1 : Form

    {
        public static api KeyAuthApp = new api(
            name: "ValorantCUstom",
            ownerid: "1loQpoBl5W",
            secret: "1e1748ae1a1dccf4e865cc7a21692fb9de4fa5aa61a3bee78d9cd201f12d4095",
            version: "1.0"
        );
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyAuthApp.init();

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
            }

            if (!KeyAuthApp.response.success)
            {
                MessageBox.Show(KeyAuthApp.response.message);
                Environment.Exit(0);
            }
            // if(KeyAuthApp.checkblack())
            // {
            //     MessageBox.Show("user is blacklisted");
            // }
            // else
            // {
            //     MessageBox.Show("user is not blacklisted");
            // }
            // check if subscription exists
            // if(SubExist("default"))
            // {
            //     MessageBox.Show("default subscription exists");
            // }
            KeyAuthApp.check();
        }

        private string random_string()
        {
            throw new NotImplementedException();
        }

     

        private void keybox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/FDvZr2aXkG");
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            KeyAuthApp.license(guna2TextBox1.Text);
            if (KeyAuthApp.response.success)
            {
                Form2 main = new Form2();
                main.Show();
                this.Hide();
            }

                
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

        
}

