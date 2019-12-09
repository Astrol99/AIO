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
            this.SuspendLayout();
            // 
            // updateOffsetsBtn
            // 
            this.updateOffsetsBtn.Location = new System.Drawing.Point(687, 12);
            this.updateOffsetsBtn.Name = "updateOffsetsBtn";
            this.updateOffsetsBtn.Size = new System.Drawing.Size(101, 46);
            this.updateOffsetsBtn.TabIndex = 0;
            this.updateOffsetsBtn.Text = "Update Offsets";
            this.updateOffsetsBtn.UseVisualStyleBackColor = true;
            this.updateOffsetsBtn.Click += new System.EventHandler(this.updateOffsetsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateOffsetsBtn);
            this.Name = "Form1";
            this.Text = "AIO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button updateOffsetsBtn;
    }
}

