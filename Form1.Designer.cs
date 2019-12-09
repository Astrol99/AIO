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
            this.ProgramTitle = new System.Windows.Forms.Label();
            this.SubText = new System.Windows.Forms.Label();
            this.ConsoleBox = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusBox = new System.Windows.Forms.GroupBox();
            this.AuthorText = new System.Windows.Forms.Label();
            this.githubLink = new System.Windows.Forms.LinkLabel();
            this.bhopCheckbox = new System.Windows.Forms.CheckBox();
            this.espCheckbox = new System.Windows.Forms.CheckBox();
            this.triggerbotCheckbox = new System.Windows.Forms.CheckBox();
            this.aimbotCheckbox = new System.Windows.Forms.CheckBox();
            this.cheatBox.SuspendLayout();
            this.ConsoleBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cheatBox
            // 
            this.cheatBox.Controls.Add(this.aimbotCheckbox);
            this.cheatBox.Controls.Add(this.triggerbotCheckbox);
            this.cheatBox.Controls.Add(this.espCheckbox);
            this.cheatBox.Controls.Add(this.bhopCheckbox);
            this.cheatBox.ForeColor = System.Drawing.Color.White;
            this.cheatBox.Location = new System.Drawing.Point(30, 120);
            this.cheatBox.Name = "cheatBox";
            this.cheatBox.Size = new System.Drawing.Size(315, 122);
            this.cheatBox.TabIndex = 1;
            this.cheatBox.TabStop = false;
            this.cheatBox.Text = "Cheats";
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
            this.ConsoleBox.Controls.Add(this.richTextBox1);
            this.ConsoleBox.ForeColor = System.Drawing.Color.White;
            this.ConsoleBox.Location = new System.Drawing.Point(351, 120);
            this.ConsoleBox.Name = "ConsoleBox";
            this.ConsoleBox.Size = new System.Drawing.Size(386, 318);
            this.ConsoleBox.TabIndex = 4;
            this.ConsoleBox.TabStop = false;
            this.ConsoleBox.Text = "Console";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(6, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(374, 293);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // statusBox
            // 
            this.statusBox.ForeColor = System.Drawing.Color.White;
            this.statusBox.Location = new System.Drawing.Point(30, 248);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(315, 190);
            this.statusBox.TabIndex = 5;
            this.statusBox.TabStop = false;
            this.statusBox.Text = "Status";
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
            this.AuthorText.Click += new System.EventHandler(this.label1_Click);
            // 
            // githubLink
            // 
            this.githubLink.AutoSize = true;
            this.githubLink.LinkColor = System.Drawing.Color.DodgerBlue;
            this.githubLink.Location = new System.Drawing.Point(576, 441);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(161, 13);
            this.githubLink.TabIndex = 7;
            this.githubLink.TabStop = true;
            this.githubLink.Text = "https://github.com/Astrol99/AIO";
            this.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLink_LinkClicked);
            // 
            // bhopCheckbox
            // 
            this.bhopCheckbox.AutoSize = true;
            this.bhopCheckbox.Location = new System.Drawing.Point(6, 19);
            this.bhopCheckbox.Name = "bhopCheckbox";
            this.bhopCheckbox.Size = new System.Drawing.Size(51, 17);
            this.bhopCheckbox.TabIndex = 0;
            this.bhopCheckbox.Text = "Bhop";
            this.bhopCheckbox.UseVisualStyleBackColor = true;
            // 
            // espCheckbox
            // 
            this.espCheckbox.AutoSize = true;
            this.espCheckbox.Location = new System.Drawing.Point(6, 42);
            this.espCheckbox.Name = "espCheckbox";
            this.espCheckbox.Size = new System.Drawing.Size(47, 17);
            this.espCheckbox.TabIndex = 1;
            this.espCheckbox.Text = "ESP";
            this.espCheckbox.UseVisualStyleBackColor = true;
            // 
            // triggerbotCheckbox
            // 
            this.triggerbotCheckbox.AutoSize = true;
            this.triggerbotCheckbox.Location = new System.Drawing.Point(6, 65);
            this.triggerbotCheckbox.Name = "triggerbotCheckbox";
            this.triggerbotCheckbox.Size = new System.Drawing.Size(74, 17);
            this.triggerbotCheckbox.TabIndex = 2;
            this.triggerbotCheckbox.Text = "Triggerbot";
            this.triggerbotCheckbox.UseVisualStyleBackColor = true;
            // 
            // aimbotCheckbox
            // 
            this.aimbotCheckbox.AutoSize = true;
            this.aimbotCheckbox.Location = new System.Drawing.Point(6, 88);
            this.aimbotCheckbox.Name = "aimbotCheckbox";
            this.aimbotCheckbox.Size = new System.Drawing.Size(58, 17);
            this.aimbotCheckbox.TabIndex = 3;
            this.aimbotCheckbox.Text = "Aimbot";
            this.aimbotCheckbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(763, 464);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cheatBox.ResumeLayout(false);
            this.cheatBox.PerformLayout();
            this.ConsoleBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox cheatBox;
        private System.Windows.Forms.Label ProgramTitle;
        private System.Windows.Forms.Label SubText;
        private System.Windows.Forms.GroupBox ConsoleBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox statusBox;
        private System.Windows.Forms.Label AuthorText;
        private System.Windows.Forms.LinkLabel githubLink;
        private System.Windows.Forms.CheckBox aimbotCheckbox;
        private System.Windows.Forms.CheckBox triggerbotCheckbox;
        private System.Windows.Forms.CheckBox espCheckbox;
        private System.Windows.Forms.CheckBox bhopCheckbox;
    }
}

