namespace AIO
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ProgramTitle = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.GroupBox();
            this.attachedStatus = new System.Windows.Forms.Label();
            this.attachLabel = new System.Windows.Forms.Label();
            this.attachCSGOBtn = new System.Windows.Forms.Button();
            this.SubText = new System.Windows.Forms.Label();
            this.Main = new System.Windows.Forms.TabPage();
            this.offsetsProgressbar = new System.Windows.Forms.ProgressBar();
            this.consoleTextbox = new System.Windows.Forms.RichTextBox();
            this.DebugTabControl = new System.Windows.Forms.TabControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cheatTabControl = new System.Windows.Forms.TabControl();
            this.BhopTab = new System.Windows.Forms.TabPage();
            this.bhopEnableCheckbox = new System.Windows.Forms.CheckBox();
            this.DettachBtn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusBox.SuspendLayout();
            this.Main.SuspendLayout();
            this.DebugTabControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.cheatTabControl.SuspendLayout();
            this.BhopTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProgramTitle
            // 
            this.ProgramTitle.AutoSize = true;
            this.ProgramTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramTitle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ProgramTitle.Location = new System.Drawing.Point(12, 9);
            this.ProgramTitle.Name = "ProgramTitle";
            this.ProgramTitle.Size = new System.Drawing.Size(211, 108);
            this.ProgramTitle.TabIndex = 2;
            this.ProgramTitle.Text = "AIO";
            // 
            // statusBox
            // 
            this.statusBox.Controls.Add(this.attachedStatus);
            this.statusBox.Controls.Add(this.attachLabel);
            this.statusBox.ForeColor = System.Drawing.Color.White;
            this.statusBox.Location = new System.Drawing.Point(459, 29);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(278, 67);
            this.statusBox.TabIndex = 5;
            this.statusBox.TabStop = false;
            this.statusBox.Text = "Status";
            // 
            // attachedStatus
            // 
            this.attachedStatus.AutoSize = true;
            this.attachedStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attachedStatus.ForeColor = System.Drawing.Color.Red;
            this.attachedStatus.Location = new System.Drawing.Point(157, 25);
            this.attachedStatus.Name = "attachedStatus";
            this.attachedStatus.Size = new System.Drawing.Size(48, 20);
            this.attachedStatus.TabIndex = 1;
            this.attachedStatus.Text = "False";
            // 
            // attachLabel
            // 
            this.attachLabel.AutoSize = true;
            this.attachLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attachLabel.Location = new System.Drawing.Point(73, 25);
            this.attachLabel.Name = "attachLabel";
            this.attachLabel.Size = new System.Drawing.Size(78, 20);
            this.attachLabel.TabIndex = 0;
            this.attachLabel.Text = "Attached:";
            // 
            // attachCSGOBtn
            // 
            this.attachCSGOBtn.Location = new System.Drawing.Point(764, 29);
            this.attachCSGOBtn.Name = "attachCSGOBtn";
            this.attachCSGOBtn.Size = new System.Drawing.Size(152, 67);
            this.attachCSGOBtn.TabIndex = 8;
            this.attachCSGOBtn.Text = "Attach To CSGO";
            this.attachCSGOBtn.UseVisualStyleBackColor = true;
            this.attachCSGOBtn.Click += new System.EventHandler(this.attachCSGOBtn_Click);
            // 
            // SubText
            // 
            this.SubText.AutoSize = true;
            this.SubText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubText.ForeColor = System.Drawing.Color.White;
            this.SubText.Location = new System.Drawing.Point(218, 54);
            this.SubText.Name = "SubText";
            this.SubText.Size = new System.Drawing.Size(157, 20);
            this.SubText.TabIndex = 3;
            this.SubText.Text = "All-in-one csgo cheat";
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.Black;
            this.Main.Controls.Add(this.offsetsProgressbar);
            this.Main.Controls.Add(this.consoleTextbox);
            this.Main.ForeColor = System.Drawing.Color.White;
            this.Main.ImageIndex = 0;
            this.Main.Location = new System.Drawing.Point(4, 23);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(3);
            this.Main.Size = new System.Drawing.Size(717, 305);
            this.Main.TabIndex = 0;
            this.Main.Text = "     Main     ";
            // 
            // offsetsProgressbar
            // 
            this.offsetsProgressbar.Location = new System.Drawing.Point(7, 277);
            this.offsetsProgressbar.Name = "offsetsProgressbar";
            this.offsetsProgressbar.Size = new System.Drawing.Size(704, 23);
            this.offsetsProgressbar.TabIndex = 1;
            // 
            // consoleTextbox
            // 
            this.consoleTextbox.BackColor = System.Drawing.Color.Black;
            this.consoleTextbox.ForeColor = System.Drawing.Color.White;
            this.consoleTextbox.Location = new System.Drawing.Point(7, 7);
            this.consoleTextbox.Name = "consoleTextbox";
            this.consoleTextbox.Size = new System.Drawing.Size(704, 264);
            this.consoleTextbox.TabIndex = 0;
            this.consoleTextbox.Text = "";
            // 
            // DebugTabControl
            // 
            this.DebugTabControl.Controls.Add(this.Main);
            this.DebugTabControl.ImageList = this.imageList1;
            this.DebugTabControl.Location = new System.Drawing.Point(12, 120);
            this.DebugTabControl.Multiline = true;
            this.DebugTabControl.Name = "DebugTabControl";
            this.DebugTabControl.SelectedIndex = 0;
            this.DebugTabControl.Size = new System.Drawing.Size(725, 332);
            this.DebugTabControl.TabIndex = 9;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "consoleImg.jpg");
            this.imageList1.Images.SetKeyName(1, "bhopImg.jpg");
            this.imageList1.Images.SetKeyName(2, "crosshair.jpg");
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cheatTabControl);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(743, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 332);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cheat Modules";
            // 
            // cheatTabControl
            // 
            this.cheatTabControl.CausesValidation = false;
            this.cheatTabControl.Controls.Add(this.BhopTab);
            this.cheatTabControl.ImageList = this.imageList1;
            this.cheatTabControl.Location = new System.Drawing.Point(6, 19);
            this.cheatTabControl.Name = "cheatTabControl";
            this.cheatTabControl.SelectedIndex = 0;
            this.cheatTabControl.Size = new System.Drawing.Size(167, 304);
            this.cheatTabControl.TabIndex = 0;
            // 
            // BhopTab
            // 
            this.BhopTab.BackColor = System.Drawing.Color.Black;
            this.BhopTab.Controls.Add(this.bhopEnableCheckbox);
            this.BhopTab.ImageKey = "bhopImg.jpg";
            this.BhopTab.Location = new System.Drawing.Point(4, 23);
            this.BhopTab.Name = "BhopTab";
            this.BhopTab.Padding = new System.Windows.Forms.Padding(3);
            this.BhopTab.Size = new System.Drawing.Size(159, 277);
            this.BhopTab.TabIndex = 0;
            this.BhopTab.Text = "Bhop";
            // 
            // bhopEnableCheckbox
            // 
            this.bhopEnableCheckbox.AutoSize = true;
            this.bhopEnableCheckbox.Location = new System.Drawing.Point(6, 3);
            this.bhopEnableCheckbox.Name = "bhopEnableCheckbox";
            this.bhopEnableCheckbox.Size = new System.Drawing.Size(59, 17);
            this.bhopEnableCheckbox.TabIndex = 0;
            this.bhopEnableCheckbox.Text = "Enable";
            this.bhopEnableCheckbox.UseVisualStyleBackColor = true;
            this.bhopEnableCheckbox.CheckedChanged += new System.EventHandler(this.bhopEnableCheckbox_CheckedChanged);
            // 
            // DettachBtn
            // 
            this.DettachBtn.Enabled = false;
            this.DettachBtn.Location = new System.Drawing.Point(764, 29);
            this.DettachBtn.Name = "DettachBtn";
            this.DettachBtn.Size = new System.Drawing.Size(152, 67);
            this.DettachBtn.TabIndex = 11;
            this.DettachBtn.Text = "Dettach To CSGO";
            this.DettachBtn.UseVisualStyleBackColor = true;
            this.DettachBtn.Visible = false;
            this.DettachBtn.Click += new System.EventHandler(this.DettachBtn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkLabel1.Location = new System.Drawing.Point(761, 455);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(160, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/astrol99/AIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "By: astr0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(705, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "v1.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(934, 473);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.DettachBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.attachCSGOBtn);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.SubText);
            this.Controls.Add(this.ProgramTitle);
            this.Controls.Add(this.DebugTabControl);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "AIO";
            this.Load += new System.EventHandler(this.Form1_Shown);
            this.statusBox.ResumeLayout(false);
            this.statusBox.PerformLayout();
            this.Main.ResumeLayout(false);
            this.DebugTabControl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.cheatTabControl.ResumeLayout(false);
            this.BhopTab.ResumeLayout(false);
            this.BhopTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ProgramTitle;
        private System.Windows.Forms.GroupBox statusBox;
        private System.Windows.Forms.Label attachLabel;
        public System.Windows.Forms.Button attachCSGOBtn;
        public System.Windows.Forms.Label attachedStatus;
        private System.Windows.Forms.Label SubText;
        private System.Windows.Forms.TabPage Main;
        public System.Windows.Forms.ProgressBar offsetsProgressbar;
        public System.Windows.Forms.RichTextBox consoleTextbox;
        private System.Windows.Forms.TabControl DebugTabControl;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl cheatTabControl;
        private System.Windows.Forms.TabPage BhopTab;
        public System.Windows.Forms.CheckBox bhopEnableCheckbox;
        public System.Windows.Forms.Button DettachBtn;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

