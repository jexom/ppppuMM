namespace ppppuMM
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
            this.uListBox = new System.Windows.Forms.ListBox();
            this.uMods = new System.Windows.Forms.Label();
            this.lMods = new System.Windows.Forms.Label();
            this.lListBox = new System.Windows.Forms.ListBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonUnload = new System.Windows.Forms.Button();
            this.buttonLAll = new System.Windows.Forms.Button();
            this.buttonUAll = new System.Windows.Forms.Button();
            this.comboPreset = new System.Windows.Forms.ComboBox();
            this.buttonPreset = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonLaunch = new System.Windows.Forms.Button();
            this.buttonModDown = new System.Windows.Forms.Button();
            this.buttonModUp = new System.Windows.Forms.Button();
            this.buttonDelPreset = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uListBox
            // 
            this.uListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uListBox.FormattingEnabled = true;
            this.uListBox.HorizontalScrollbar = true;
            this.uListBox.ItemHeight = 37;
            this.uListBox.Location = new System.Drawing.Point(20, 50);
            this.uListBox.Name = "uListBox";
            this.uListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.uListBox.Size = new System.Drawing.Size(400, 559);
            this.uListBox.TabIndex = 0;
            // 
            // uMods
            // 
            this.uMods.AutoSize = true;
            this.uMods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uMods.Location = new System.Drawing.Point(12, 9);
            this.uMods.Name = "uMods";
            this.uMods.Size = new System.Drawing.Size(242, 37);
            this.uMods.TabIndex = 1;
            this.uMods.Text = "Unloaded mods";
            // 
            // lMods
            // 
            this.lMods.AutoSize = true;
            this.lMods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lMods.Location = new System.Drawing.Point(661, 10);
            this.lMods.Name = "lMods";
            this.lMods.Size = new System.Drawing.Size(212, 37);
            this.lMods.TabIndex = 3;
            this.lMods.Text = "Loaded mods";
            // 
            // lListBox
            // 
            this.lListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lListBox.FormattingEnabled = true;
            this.lListBox.HorizontalScrollbar = true;
            this.lListBox.ItemHeight = 37;
            this.lListBox.Location = new System.Drawing.Point(668, 50);
            this.lListBox.Name = "lListBox";
            this.lListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lListBox.Size = new System.Drawing.Size(400, 559);
            this.lListBox.TabIndex = 2;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoad.Location = new System.Drawing.Point(435, 56);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(50, 50);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Text = ">";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonUnload
            // 
            this.buttonUnload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUnload.Location = new System.Drawing.Point(435, 112);
            this.buttonUnload.Name = "buttonUnload";
            this.buttonUnload.Size = new System.Drawing.Size(50, 50);
            this.buttonUnload.TabIndex = 5;
            this.buttonUnload.Text = "<";
            this.buttonUnload.UseVisualStyleBackColor = true;
            this.buttonUnload.Click += new System.EventHandler(this.buttonUnload_Click);
            // 
            // buttonLAll
            // 
            this.buttonLAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLAll.Location = new System.Drawing.Point(435, 168);
            this.buttonLAll.Name = "buttonLAll";
            this.buttonLAll.Size = new System.Drawing.Size(130, 50);
            this.buttonLAll.TabIndex = 9;
            this.buttonLAll.Text = "> All";
            this.buttonLAll.UseVisualStyleBackColor = true;
            this.buttonLAll.Click += new System.EventHandler(this.buttonLAll_Click);
            // 
            // buttonUAll
            // 
            this.buttonUAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUAll.Location = new System.Drawing.Point(435, 224);
            this.buttonUAll.Name = "buttonUAll";
            this.buttonUAll.Size = new System.Drawing.Size(130, 50);
            this.buttonUAll.TabIndex = 10;
            this.buttonUAll.Text = "< All";
            this.buttonUAll.UseVisualStyleBackColor = true;
            this.buttonUAll.Click += new System.EventHandler(this.buttonUAll_Click);
            // 
            // comboPreset
            // 
            this.comboPreset.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboPreset.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboPreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboPreset.FormattingEnabled = true;
            this.comboPreset.ItemHeight = 37;
            this.comboPreset.Items.AddRange(new object[] {
            "default"});
            this.comboPreset.Location = new System.Drawing.Point(20, 615);
            this.comboPreset.Name = "comboPreset";
            this.comboPreset.Size = new System.Drawing.Size(400, 45);
            this.comboPreset.Sorted = true;
            this.comboPreset.TabIndex = 11;
            this.comboPreset.SelectedIndexChanged += new System.EventHandler(this.comboPreset_SelectedIndexChanged);
            // 
            // buttonPreset
            // 
            this.buttonPreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPreset.Location = new System.Drawing.Point(20, 675);
            this.buttonPreset.Name = "buttonPreset";
            this.buttonPreset.Size = new System.Drawing.Size(196, 50);
            this.buttonPreset.TabIndex = 12;
            this.buttonPreset.Text = "Save";
            this.buttonPreset.UseVisualStyleBackColor = true;
            this.buttonPreset.Click += new System.EventHandler(this.buttonPreset_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLog.Location = new System.Drawing.Point(668, 675);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(400, 50);
            this.buttonLog.TabIndex = 13;
            this.buttonLog.Text = "Export PPPPU Logs";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // buttonLaunch
            // 
            this.buttonLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLaunch.Location = new System.Drawing.Point(668, 619);
            this.buttonLaunch.Name = "buttonLaunch";
            this.buttonLaunch.Size = new System.Drawing.Size(400, 50);
            this.buttonLaunch.TabIndex = 14;
            this.buttonLaunch.Text = "Launch PPPPU";
            this.buttonLaunch.UseVisualStyleBackColor = true;
            this.buttonLaunch.Click += new System.EventHandler(this.buttonLaunch_Click);
            // 
            // buttonModDown
            // 
            this.buttonModDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonModDown.Location = new System.Drawing.Point(612, 112);
            this.buttonModDown.Name = "buttonModDown";
            this.buttonModDown.Size = new System.Drawing.Size(50, 50);
            this.buttonModDown.TabIndex = 16;
            this.buttonModDown.Text = "↓";
            this.buttonModDown.UseVisualStyleBackColor = true;
            this.buttonModDown.Click += new System.EventHandler(this.buttonModDown_Click);
            // 
            // buttonModUp
            // 
            this.buttonModUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonModUp.Location = new System.Drawing.Point(612, 56);
            this.buttonModUp.Name = "buttonModUp";
            this.buttonModUp.Size = new System.Drawing.Size(50, 50);
            this.buttonModUp.TabIndex = 15;
            this.buttonModUp.Text = "↑";
            this.buttonModUp.UseVisualStyleBackColor = true;
            this.buttonModUp.Click += new System.EventHandler(this.buttonModUp_Click);
            // 
            // buttonDelPreset
            // 
            this.buttonDelPreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelPreset.Location = new System.Drawing.Point(224, 675);
            this.buttonDelPreset.Name = "buttonDelPreset";
            this.buttonDelPreset.Size = new System.Drawing.Size(196, 50);
            this.buttonDelPreset.TabIndex = 17;
            this.buttonDelPreset.Text = "Delete";
            this.buttonDelPreset.UseVisualStyleBackColor = true;
            this.buttonDelPreset.Click += new System.EventHandler(this.buttonDelPreset_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp.Location = new System.Drawing.Point(435, 610);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(130, 50);
            this.buttonHelp.TabIndex = 18;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 737);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonDelPreset);
            this.Controls.Add(this.buttonModDown);
            this.Controls.Add(this.buttonModUp);
            this.Controls.Add(this.buttonLaunch);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonPreset);
            this.Controls.Add(this.comboPreset);
            this.Controls.Add(this.buttonUAll);
            this.Controls.Add(this.buttonLAll);
            this.Controls.Add(this.buttonUnload);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.lMods);
            this.Controls.Add(this.lListBox);
            this.Controls.Add(this.uMods);
            this.Controls.Add(this.uListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "PPPPU Mod Manager v1.0.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox uListBox;
        private System.Windows.Forms.Label uMods;
        private System.Windows.Forms.Label lMods;
        private System.Windows.Forms.ListBox lListBox;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonUnload;
        private System.Windows.Forms.Button buttonLAll;
        private System.Windows.Forms.Button buttonUAll;
        private System.Windows.Forms.ComboBox comboPreset;
        private System.Windows.Forms.Button buttonPreset;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonLaunch;
        private System.Windows.Forms.Button buttonModDown;
        private System.Windows.Forms.Button buttonModUp;
        private System.Windows.Forms.Button buttonDelPreset;
        private System.Windows.Forms.Button buttonHelp;
    }
}

