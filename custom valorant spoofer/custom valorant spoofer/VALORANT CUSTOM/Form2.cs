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

namespace VALORANT_CUSTOM
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private WebClient webclient = new WebClient();

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            string fileName = "C:\\Program Files\\revosetup.exe";
            string adress = "https://cdn.discordapp.com/attachments/1099840659164233891/1114971035020836984/revosetup.exe";
            bool flag = File.Exists(fileName);  
            if (flag)
            {
                File.Delete(fileName);
            }
            this.webclient.DownloadFile(adress, fileName);
            Process.Start(fileName);    
        }
       

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            string fileName = "C:\\Program Files\\GRINX64v2.zip";
            string adress = "https://cdn.discordapp.com/attachments/1036244055841062932/1036698814502944800/GRINX64v2.zip";
            bool flag = File.Exists(fileName);
            if (flag)
            {
                File.Delete(fileName);
            }
            this.webclient.DownloadFile(adress, fileName);
            Process.Start(fileName);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            string fileName = "C:\\Program Files\\checker.bat";
            string adress = "https://cdn.discordapp.com/attachments/1100090296043311236/1117496318408003677/checker_nuevo.bat";
            bool flag = File.Exists(fileName);
            if (flag)
            {
                File.Delete(fileName);
            }
            this.webclient.DownloadFile(adress, fileName);
            Process.Start(fileName);
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            string fileName = "C:\\Program Files\\spoofer.exe";
            string adress = "https://cdn.discordapp.com/attachments/1100090296043311236/1129450247748341830/spoofer.exe";
            bool flag = File.Exists(fileName);
            if (flag)
            {
                File.Delete(fileName);
            }
            this.webclient.DownloadFile(adress, fileName);
            Process.Start(fileName);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            string fileName = "C:\\Program Files\\checker.bat";
            string adress = "https://cdn.discordapp.com/attachments/1100090296043311236/1117496318408003677/checker_nuevo.bat";
            bool flag = File.Exists(fileName);
            if (flag)
            {
                File.Delete(fileName);
            }
            this.webclient.DownloadFile(adress, fileName);
            Process.Start(fileName);
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            string fileName = "C:\\Program Files\\spoofer.exe";
            string adress = "https://cdn.discordapp.com/attachments/1100090296043311236/1129450247748341830/spoofer.exe";
            bool flag = File.Exists(fileName);
            if (flag)
            {
                File.Delete(fileName);
            }
            this.webclient.DownloadFile(adress, fileName);
            Process.Start(fileName);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string fileName = "C:\\Program Files\\GRINX64v2.zip";
            string adress = "https://cdn.discordapp.com/attachments/1036244055841062932/1036698814502944800/GRINX64v2.zip";
            bool flag = File.Exists(fileName);
            if (flag)
            {
                File.Delete(fileName);
            }
            this.webclient.DownloadFile(adress, fileName);
            Process.Start(fileName);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Process.Start("https://streamable.com/pp8ij9");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://streamable.com/pp8ij9");
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
