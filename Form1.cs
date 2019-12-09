using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // First things to do when window opens
        private void Form1_Load(object sender, EventArgs e)
        {
            // Check if offsets file exists
            UpdateStuff.askUser();
        }

        private void updateOffsetsBtn_Click(object sender, EventArgs e)
        {
            UpdateStuff.getOffsets();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void githubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Astrol99/AIO");
        }
    }
}
