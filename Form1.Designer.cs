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
            this.updateOffsetsBtn = new System.Windows.Forms.Button();
            this.cheatBox = new System.Windows.Forms.GroupBox();
            this.ProgramTitle = new System.Windows.Forms.Label();
            this.SubText = new System.Windows.Forms.Label();
            this.ConsoleBox = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusBox = new System.Windows.Forms.GroupBox();
            this.AuthorText = new System.Windows.Forms.Label();
            this.githubLink = new System.Windows.Forms.LinkLabel();
            this.ConsoleBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateOffsetsBtn
            // 
            this.updateOffsetsBtn.Location = new System.Drawing.Point(636, 39);
            this.updateOffsetsBtn.Name = "updateOffsetsBtn";
            this.updateOffsetsBtn.Size = new System.Drawing.Size(101, 46);
            this.updateOffsetsBtn.TabIndex = 0;
            this.updateOffsetsBtn.Text = "Update Offsets";
            this.updateOffsetsBtn.UseVisualStyleBackColor = true;
            this.updateOffsetsBtn.Click += new System.EventHandler(this.updateOffsetsBtn_Click);
            // 
            // cheatBox
            // 
            this.cheatBox.ForeColor = System.Drawing.Color.White;
            this.cheatBox.Location = new System.Drawing.Point(30, 120);
            this.cheatBox.Name = "cheatBox";
            this.cheatBox.Size = new System.Drawing.Size(315, 99);
            this.cheatBox.TabIndex = 1;
            this.cheatBox.TabStop = false;
            this.cheatBox.Text = "Cheats";
            this.cheatBox.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.statusBox.Location = new System.Drawing.Point(30, 225);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(315, 213);
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
            this.Controls.Add(this.updateOffsetsBtn);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "AIO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ConsoleBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateOffsetsBtn;
        private System.Windows.Forms.GroupBox cheatBox;
        private System.Windows.Forms.Label ProgramTitle;
        private System.Windows.Forms.Label SubText;
        private System.Windows.Forms.GroupBox ConsoleBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox statusBox;
        private System.Windows.Forms.Label AuthorText;
        private System.Windows.Forms.LinkLabel githubLink;
    }
}

