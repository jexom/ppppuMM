using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppppuMMUpdater
{
    public partial class Form1 : Form
    {
        Boolean newVer = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (!newVer)
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadFileCompleted += wc_DownloadVerFileCompleted;
                    wc.DownloadFileAsync(new System.Uri("https://www.dropbox.com/s/1ewxhi8zk3skq2e/ModManagerVersion?dl=1"), "./ver");
                }
                label1.Text = "Checking for updates...";
            }
            else
            {
                using (WebClient wcMM = new WebClient())
                {
                    wcMM.DownloadFileCompleted += wc_DownloadMMFileCompleted;
                    wcMM.DownloadFileAsync(new System.Uri("https://www.dropbox.com/s/e5udj3pu4e5n5fw/ppppuMM.zip?dl=1"), "./ppppuMMUpd.zip");
                }
            }
        }

        private void wc_DownloadVerFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            string curVerStr = "0";
            if (File.Exists("./ModManagerVersion")) {
                curVerStr = File.ReadAllText("./ModManagerVersion");
            }
            string updVerStr = File.ReadAllText("./ver");
            int curVer, updVer;
            Int32.TryParse(curVerStr, out curVer);
            Int32.TryParse(updVerStr, out updVer);
            if (updVer > curVer)
            {
                label1.Text = "A new version of Mod Manager is available";
                updateButton.Text = "Update now";
                newVer = true;
            }
            else
            {
                label1.Text = "No updates for Mod Manager are available";
            }
            updateButton.Enabled = true;
            File.Delete("./ver");
        }

        private void wc_DownloadMMFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            using (WebClient wcMM = new WebClient())
            {
                wcMM.DownloadFile(new System.Uri("https://www.dropbox.com/s/1ewxhi8zk3skq2e/ModManagerVersion?dl=1"), "./ver");
                if (!File.Exists("./ppppuMM.exe"))
                {
                    File.WriteAllText("./ppppuMM.exe", "");
                }
                if (File.Exists("./ppppuMM.exe"))
                {
                    File.Delete("./ppppuMM.exe");
                }
                if (File.Exists("./flashplayer_30_sa.exe"))
                {
                    File.Delete("./flashplayer_30_sa.exe");
                }
                ZipFile.ExtractToDirectory("./ppppuMMUpd.zip", "./");
                File.Delete("./ppppuMMUpd.zip");
                if (!File.Exists("./ModManagerVersion"))
                {
                    File.WriteAllText("./ModManagerVersion", "");
                }
                File.Replace("./ver", "./ModManagerVersion", "./ver1");
                File.Delete("./ver");
                File.Delete("./ver1");
                label1.Text = "Update completed";
            }
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            using (WebClient wcp = new WebClient())
            {
                wcp.DownloadFileCompleted += wcp_DownloadPreviewsFileCompleted;
                wcp.DownloadProgressChanged += wcp_DownloadProgressChanged;
                wcp.DownloadFileAsync(new System.Uri("https://www.dropbox.com/s/ptusoi2ay9j154z/previews.zip?dl=1"), "./previews.zip");
            }
        }

        private void wcp_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void wcp_DownloadPreviewsFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (Directory.Exists("./presets/previews"))
            {
                Directory.Delete("./presets/previews", true);
            }
            Directory.CreateDirectory("./presets/previews");
            ZipFile.ExtractToDirectory("./previews.zip", "./presets/previews");
            label1.Text = "Previews download completed";
            File.Delete("./previews.zip");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (WebClient wc = new WebClient())
            {
                wc.DownloadFileCompleted += wc_DownloadVerFileCompleted;
                wc.DownloadFileAsync(new System.Uri("https://www.dropbox.com/s/1ewxhi8zk3skq2e/ModManagerVersion?dl=1"), "./ver");
            }
        }
    }
}
