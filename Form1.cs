using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace AIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _Form1 = this;
        }

        public static Form1 _Form1;

        // Things to run when form has loaded and displayed
        private void Form1_Shown(Object sender, EventArgs e)
        {
            // Download offsets right when user launches program
            getOffsets();
        }

        
        // Get offsets
        private void getOffsets()
        {
            OffsetHandler offsetHandler = new OffsetHandler();

            offsetHandler.getOffsets();
        }
        

        private void githubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Astrol99/AIO");
        }

        // Main cheat initation
        private void attachCSGOBtn_Click(object sender, EventArgs e)
        {
            ProcessHandler ph = new ProcessHandler();
            
        }
    }
}
