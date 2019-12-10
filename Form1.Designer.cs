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
            this.cheatBox = new System.Windows.Forms.GroupBox();
            this.cheatTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ProgramTitle = new System.Windows.Forms.Label();
            this.SubText = new System.Windows.Forms.Label();
            this.ConsoleBox = new System.Windows.Forms.GroupBox();
            this.consoleTextbox = new System.Windows.Forms.RichTextBox();
            this.statusBox = new System.Windows.Forms.GroupBox();
            this.attachedStatus = new System.Windows.Forms.Label();
            this.attachLabel = new System.Windows.Forms.Label();
            this.AuthorText = new System.Windows.Forms.Label();
            this.githubLink = new System.Windows.Forms.LinkLabel();
            this.attachCSGOBtn = new System.Windows.Forms.Button();
            this.playersGroupBox = new System.Windows.Forms.GroupBox();
            this.versionLabel = new System.Windows.Forms.Label();
            this.cheatBox.SuspendLayout();
            this.cheatTabs.SuspendLayout();
            this.ConsoleBox.SuspendLayout();
            this.statusBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cheatBox
            // 
            this.cheatBox.Controls.Add(this.cheatTabs);
            this.cheatBox.ForeColor = System.Drawing.Color.White;
            this.cheatBox.Location = new System.Drawing.Point(30, 120);
            this.cheatBox.Name = "cheatBox";
            this.cheatBox.Size = new System.Drawing.Size(278, 245);
            this.cheatBox.TabIndex = 1;
            this.cheatBox.TabStop = false;
            this.cheatBox.Text = "Cheat Modules";
            // 
            // cheatTabs
            // 
            this.cheatTabs.Controls.Add(this.tabPage1);
            this.cheatTabs.Controls.Add(this.tabPage2);
            this.cheatTabs.Controls.Add(this.tabPage3);
            this.cheatTabs.Controls.Add(this.tabPage4);
            this.cheatTabs.Location = new System.Drawing.Point(7, 14);
            this.cheatTabs.Name = "cheatTabs";
            this.cheatTabs.SelectedIndex = 0;
            this.cheatTabs.Size = new System.Drawing.Size(265, 225);
            this.cheatTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(257, 199);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ESP";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(257, 199);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bhop";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(257, 199);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Aimbot";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(257, 199);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Antiaim";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ProgramTitle
            // 
            this.ProgramTitle.AutoSize = true;
            this.ProgramTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramTitle.ForeColor = System.Drawing.Color.White;
            this.ProgramTitle.Location = new System.Drawing.Point(12, 9);
            this.ProgramTitle.Name = "ProgramTitle";
            this.ProgramTitle.Size = new System.Drawing.Size(211, 108);
            this.ProgramTitle.TabIndex = 2;
            this.ProgramTitle.Text = "AIO";
            // 
            // SubText
            // 
            this.SubText.AutoSize = true;
            this.SubText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubText.ForeColor = System.Drawing.Color.White;
            this.SubText.Location = new System.Drawing.Point(215, 51);
            this.SubText.Name = "SubText";
            this.SubText.Size = new System.Drawing.Size(157, 20);
            this.SubText.TabIndex = 3;
            this.SubText.Text = "All-in-one csgo cheat";
            // 
            // ConsoleBox
            // 
            this.ConsoleBox.Controls.Add(this.consoleTextbox);
            this.ConsoleBox.ForeColor = System.Drawing.Color.White;
            this.ConsoleBox.Location = new System.Drawing.Point(314, 120);
            this.ConsoleBox.Name = "ConsoleBox";
            this.ConsoleBox.Size = new System.Drawing.Size(423, 318);
            this.ConsoleBox.TabIndex = 4;
            this.ConsoleBox.TabStop = false;
            this.ConsoleBox.Text = "Console";
            // 
            // consoleTextbox
            // 
            this.consoleTextbox.BackColor = System.Drawing.Color.Black;
            this.consoleTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleTextbox.ForeColor = System.Drawing.Color.White;
            this.consoleTextbox.Location = new System.Drawing.Point(6, 19);
            this.consoleTextbox.Name = "consoleTextbox";
            this.consoleTextbox.ReadOnly = true;
            this.consoleTextbox.Size = new System.Drawing.Size(411, 293);
            this.consoleTextbox.TabIndex = 0;
            this.consoleTextbox.Text = "";
            // 
            // statusBox
            // 
            this.statusBox.Controls.Add(this.attachedStatus);
            this.statusBox.Controls.Add(this.attachLabel);
            this.statusBox.ForeColor = System.Drawing.Color.White;
            this.statusBox.Location = new System.Drawing.Point(30, 371);
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
            // AuthorText
            // 
            this.AuthorText.AutoSize = true;
            this.AuthorText.ForeColor = System.Drawing.Color.White;
            this.AuthorText.Location = new System.Drawing.Point(27, 441);
            this.AuthorText.Name = "AuthorText";
            this.AuthorText.Size = new System.Drawing.Size(48, 13);
            this.AuthorText.TabIndex = 6;
            this.AuthorText.Text = "By: astr0";
            // 
            // githubLink
            // 
            this.githubLink.AutoSize = true;
            this.githubLink.LinkColor = System.Drawing.Color.DodgerBlue;
            this.githubLink.Location = new System.Drawing.Point(74, 441);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(161, 13);
            this.githubLink.TabIndex = 7;
            this.githubLink.TabStop = true;
            this.githubLink.Text = "https://github.com/Astrol99/AIO";
            this.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLink_LinkClicked);
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
            // playersGroupBox
            // 
            this.playersGroupBox.ForeColor = System.Drawing.Color.White;
            this.playersGroupBox.Location = new System.Drawing.Point(743, 120);
            this.playersGroupBox.Name = "playersGroupBox";
            this.playersGroupBox.Size = new System.Drawing.Size(179, 318);
            this.playersGroupBox.TabIndex = 9;
            this.playersGroupBox.TabStop = false;
            this.playersGroupBox.Text = "Players";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.ForeColor = System.Drawing.Color.White;
            this.versionLabel.Location = new System.Drawing.Point(894, 441);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(28, 13);
            this.versionLabel.TabIndex = 10;
            this.versionLabel.Text = "v1.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(934, 464);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.playersGroupBox);
            this.Controls.Add(this.attachCSGOBtn);
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.AuthorText);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.ConsoleBox);
            this.Controls.Add(this.SubText);
            this.Controls.Add(this.ProgramTitle);
            this.Controls.Add(this.cheatBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "AIO";
            this.Load += new System.EventHandler(this.Form1_Shown);
            this.cheatBox.ResumeLayout(false);
            this.cheatTabs.ResumeLayout(false);
            this.ConsoleBox.ResumeLayout(false);
            this.statusBox.ResumeLayout(false);
            this.statusBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox cheatBox;
        private System.Windows.Forms.Label ProgramTitle;
        private System.Windows.Forms.Label SubText;
        private System.Windows.Forms.GroupBox ConsoleBox;
        private System.Windows.Forms.RichTextBox consoleTextbox;
        private System.Windows.Forms.GroupBox statusBox;
        private System.Windows.Forms.Label AuthorText;
        private System.Windows.Forms.LinkLabel githubLink;
        private System.Windows.Forms.Button attachCSGOBtn;
        private System.Windows.Forms.Label attachedStatus;
        private System.Windows.Forms.Label attachLabel;
        private System.Windows.Forms.GroupBox playersGroupBox;
        private System.Windows.Forms.TabControl cheatTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label versionLabel;
    }
}

