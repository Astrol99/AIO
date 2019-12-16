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
            this.offsetsProgressbar = new System.Windows.Forms.ProgressBar();
            this.ConsoleBox.SuspendLayout();
            this.statusBox.SuspendLayout();
            this.SuspendLayout();
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
            this.ConsoleBox.Location = new System.Drawing.Point(30, 120);
            this.ConsoleBox.Name = "ConsoleBox";
            this.ConsoleBox.Size = new System.Drawing.Size(707, 318);
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
            this.consoleTextbox.Size = new System.Drawing.Size(695, 293);
            this.consoleTextbox.TabIndex = 0;
            this.consoleTextbox.Text = "";
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
            // offsetsProgressbar
            // 
            this.offsetsProgressbar.Location = new System.Drawing.Point(241, 441);
            this.offsetsProgressbar.Name = "offsetsProgressbar";
            this.offsetsProgressbar.Size = new System.Drawing.Size(681, 16);
            this.offsetsProgressbar.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(934, 464);
            this.Controls.Add(this.offsetsProgressbar);
            this.Controls.Add(this.playersGroupBox);
            this.Controls.Add(this.attachCSGOBtn);
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.AuthorText);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.ConsoleBox);
            this.Controls.Add(this.SubText);
            this.Controls.Add(this.ProgramTitle);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "AIO";
            this.Load += new System.EventHandler(this.Form1_Shown);
            this.ConsoleBox.ResumeLayout(false);
            this.statusBox.ResumeLayout(false);
            this.statusBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ProgramTitle;
        private System.Windows.Forms.Label SubText;
        private System.Windows.Forms.GroupBox ConsoleBox;
        private System.Windows.Forms.GroupBox statusBox;
        private System.Windows.Forms.Label AuthorText;
        private System.Windows.Forms.LinkLabel githubLink;
        private System.Windows.Forms.Label attachLabel;
        private System.Windows.Forms.GroupBox playersGroupBox;
        public System.Windows.Forms.Button attachCSGOBtn;
        public System.Windows.Forms.Label attachedStatus;
        public System.Windows.Forms.ProgressBar offsetsProgressbar;
        public System.Windows.Forms.RichTextBox consoleTextbox;
    }
}

