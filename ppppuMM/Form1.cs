using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ppppuMM
{
    public partial class Form1 : Form
    {
        RTFM rtfm = new RTFM();
        private void LoadMods(string filename, bool preset)
        {
            uListBox.Items.Clear();
            lListBox.Items.Clear();
            List<string> mods = new List<string>();
            string[] files = Directory.GetFiles(".");
            foreach (string nmod in files)
            {
                string mod = nmod.Remove(0, 2);
                if ((mod.IndexOf("ACHAR_") == 0 || mod.IndexOf("ARCH_") == 0 || mod.IndexOf("M_") == 0 || mod.IndexOf("M_") == 0) &&
                    mod != "ARCH_BaseAssets.swf")
                {
                    mods.Add(mod);
                }
            }

            string file = "./" + (preset ? "presets/" : "") + filename + ".txt";
            string[] loaded = File.Exists(file) ? File.ReadAllLines(file) : new string[0];
            foreach (string mod in loaded)
            {
                if (mod.IndexOf('#') != 0 && mod != "")
                {
                    lListBox.Items.Add(mod);
                }
            }

            foreach (string mod in mods)
            {
                if (!lListBox.Items.Contains(mod))
                    uListBox.Items.Add(mod);
            }

            string[] presets = Directory.GetFiles("./presets");
            comboPreset.Items.Clear();
            foreach (string presetFile in presets)
            {
                file = presetFile.Remove(0, 10);
                if (file.IndexOf(".") != 0)
                    comboPreset.Items.Add(file.Substring(0, file.Length - 4));
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("ppppuXi.swf"))
            {
                MessageBox.Show("No ppppuXi.swf found in folder! Have you put the modmanager into your PPPPU folder?",
                        "File not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            
            if (!Directory.Exists("./presets"))
            {
                rtfm.ShowDialog();
                Directory.CreateDirectory("./presets");
            }
            if(File.Exists("./ModsList.txt"))
                File.Copy("./ModsList.txt", "./presets/.default.txt", true);
            
            LoadMods(".default", true);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            object[] unloaded = new object[uListBox.SelectedItems.Count];
            uListBox.SelectedItems.CopyTo(unloaded, 0);
            foreach (object mod in unloaded)
            {
                lListBox.Items.Add(mod);
                uListBox.Items.Remove(mod);
            }
            saveFile(".temp", true);
        }

        private void buttonUnload_Click(object sender, EventArgs e)
        {
            object[] loaded = new object[lListBox.SelectedItems.Count];
            lListBox.SelectedItems.CopyTo(loaded, 0);
            foreach (object mod in loaded)
            {
                uListBox.Items.Add(mod);
                lListBox.Items.Remove(mod);
            }
            saveFile(".temp", true);
        }

        private void buttonLAll_Click(object sender, EventArgs e)
        {
            object[] unloaded = new object[uListBox.Items.Count];
            uListBox.Items.CopyTo(unloaded, 0);
            foreach (object mod in unloaded)
            {
                lListBox.Items.Add(mod);
                uListBox.Items.Remove(mod);
            }
            saveFile(".temp", true);
        }

        private void buttonUAll_Click(object sender, EventArgs e)
        {
            object[] loaded = new object[lListBox.Items.Count];
            lListBox.Items.CopyTo(loaded, 0);
            foreach (object mod in loaded)
            {
                uListBox.Items.Add(mod);
                lListBox.Items.Remove(mod);
            }
            saveFile(".temp", true);
        }

        private void buttonPreset_Click(object sender, EventArgs e)
        {
            saveFile(comboPreset.Text, true);
            saveFile("ModsList", false);
        }

        private void comboPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMods(comboPreset.Text, true);
            saveFile("ModsList", false);
        }

        private void saveFile(string filename, bool preset)
        {
            string chars = "";
            string archs = "";
            string ms = "";
            string anims = "";

            foreach (string mod in lListBox.Items)
            {
                switch (mod.Substring(0, mod.IndexOf("_")))
                {
                    case "ACHAR":
                        chars += mod + "\r\n";
                        break;
                    case "ARCH":
                        archs += mod + "\r\n";
                        break;
                    case "M":
                        ms += mod + "\r\n";
                        break;
                    case "ANIM":
                        anims += mod + "\r\n";
                        break;
                }
            }

            string loadStr = "#Animated Characters\r\n" + chars +
                "\r\n#Archives\r\n" + archs +
                "\r\n#Music\r\n" + ms +
                "\r\n#Animations\r\n" + anims;


            File.WriteAllText("./" + (preset ? "presets/" : "") + filename + ".txt", loadStr);
            LoadMods(filename, preset);
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).Replace("\\", "/");
            string ppppuLog = Directory.GetFiles(appdata + "/Macromedia/Flash Player/#SharedObjects", "ppppuXi_Log.sol", SearchOption.AllDirectories)[0].Replace("\\", "/");
            string[] logText = File.ReadAllLines(ppppuLog);
            logText[0] = logText[0].Substring(0x2D);
            logText[logText.Length - 1] = logText[logText.Length - 1].Remove(logText[logText.Length - 1].Length - 1, 1);
            File.WriteAllLines("ppppuXi_Log.txt", logText);
        }

        private void buttonLaunch_Click(object sender, EventArgs e)
        {
            saveFile("ModsList", false);
            if (File.Exists("flashplayer_30_sa.exe"))
            {
                Process.Start("flashplayer_30_sa.exe", "ppppuXi.swf");
                Application.Exit();
            } else
            {
                MessageBox.Show("No flashplayer_30_sa.exe found in folder!", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonModUp_Click(object sender, EventArgs e)
        {
            MoveItem(-1);
        }

        private void buttonModDown_Click(object sender, EventArgs e)
        {
            MoveItem(1);
        }

        private void MoveItem(int direction)
        {
            if (lListBox.SelectedItem == null || lListBox.SelectedIndex < 0)
                return;
            
            int newIndex = lListBox.SelectedIndex + direction;
            
            if (newIndex < 0 || newIndex >= lListBox.Items.Count)
                return; // Index out of range - nothing to do

            object selected = lListBox.SelectedItem;
            
            lListBox.Items.Remove(selected);
            lListBox.Items.Insert(newIndex, selected);
            lListBox.SetSelected(newIndex, true);
        }

        private void buttonDelPreset_Click(object sender, EventArgs e)
        {
            if (File.Exists("./presets/" + comboPreset.Text + ".txt"))
                File.Delete("./presets/" + comboPreset.Text + ".txt");
            comboPreset.Text = "";
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            rtfm = new RTFM();
            rtfm.ShowDialog();
        }
    }
}