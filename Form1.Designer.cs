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
            this.BhopTab = new System.Windows.Forms.TabPage();
            this.Main = new System.Windows.Forms.TabPage();
            this.consoleTextbox = new System.Windows.Forms.RichTextBox();
            this.offsetsProgressbar = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bhopEnableCheckbox = new System.Windows.Forms.CheckBox();
            this.statusBox.SuspendLayout();
            this.BhopTab.SuspendLayout();
            this.Main.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            // BhopTab
            // 
            this.BhopTab.BackColor = System.Drawing.Color.Black;
            this.BhopTab.Controls.Add(this.bhopEnableCheckbox);
            this.BhopTab.ForeColor = System.Drawing.Color.White;
            this.BhopTab.ImageKey = "bhopImg.jpg";
            this.BhopTab.Location = new System.Drawing.Point(4, 23);
            this.BhopTab.Name = "BhopTab";
            this.BhopTab.Padding = new System.Windows.Forms.Padding(3);
            this.BhopTab.Size = new System.Drawing.Size(902, 305);
            this.BhopTab.TabIndex = 1;
            this.BhopTab.Text = "Bhop";
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
            this.Main.Size = new System.Drawing.Size(902, 305);
            this.Main.TabIndex = 0;
            this.Main.Text = "Main";
            // 
            // consoleTextbox
            // 
            this.consoleTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.consoleTextbox.ForeColor = System.Drawing.Color.White;
            this.consoleTextbox.Location = new System.Drawing.Point(7, 7);
            this.consoleTextbox.Name = "consoleTextbox";
            this.consoleTextbox.Size = new System.Drawing.Size(889, 264);
            this.consoleTextbox.TabIndex = 0;
            this.consoleTextbox.Text = "";
            // 
            // offsetsProgressbar
            // 
            this.offsetsProgressbar.Location = new System.Drawing.Point(7, 277);
            this.offsetsProgressbar.Name = "offsetsProgressbar";
            this.offsetsProgressbar.Size = new System.Drawing.Size(889, 23);
            this.offsetsProgressbar.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Main);
            this.tabControl1.Controls.Add(this.BhopTab);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(12, 120);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(910, 332);
            this.tabControl1.TabIndex = 9;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "consoleImg.jpg");
            this.imageList1.Images.SetKeyName(1, "bhopImg.jpg");
            // 
            // bhopEnableCheckbox
            // 
            this.bhopEnableCheckbox.AutoSize = true;
            this.bhopEnableCheckbox.Location = new System.Drawing.Point(14, 7);
            this.bhopEnableCheckbox.Name = "bhopEnableCheckbox";
            this.bhopEnableCheckbox.Size = new System.Drawing.Size(59, 17);
            this.bhopEnableCheckbox.TabIndex = 0;
            this.bhopEnableCheckbox.Text = "Enable";
            this.bhopEnableCheckbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(934, 464);
            this.Controls.Add(this.attachCSGOBtn);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.SubText);
            this.Controls.Add(this.ProgramTitle);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "AIO";
            this.Load += new System.EventHandler(this.Form1_Shown);
            this.statusBox.ResumeLayout(false);
            this.statusBox.PerformLayout();
            this.BhopTab.ResumeLayout(false);
            this.BhopTab.PerformLayout();
            this.Main.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage BhopTab;
        private System.Windows.Forms.TabPage Main;
        public System.Windows.Forms.ProgressBar offsetsProgressbar;
        public System.Windows.Forms.RichTextBox consoleTextbox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox bhopEnableCheckbox;
    }
}

