using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace AIO
{
    public partial class Form1 : Form
    {
        // Offsets needed
        public static Newtonsoft.Json.Linq.JObject sig;
        public static Newtonsoft.Json.Linq.JObject netvars;

        public Form1()
        {
            InitializeComponent();
        }

        // First things to do when window opens
        private void Form1_Load(object sender, EventArgs e)
        {
            // Download offsets right when user launches program
            debug("Downloading offsets...");
            var rawJson = OffsetsHandler.getOffsets();
            debug("Done!");
            OffsetsHandler.deserializeJSON(rawJson);
            debug("Deserialized and parsed raw offsets from https://github.com/frk1/hazedumper/blob/master/csgo.json");
        }

        private void debug(string text)
        {
            Debug.Write(text + Environment.NewLine);
            text = DateTime.Now.ToString("[h:mm:ss tt] ") + text + Environment.NewLine;
            consoleTextbox.Text = consoleTextbox.Text + text;
            consoleTextbox.SelectionStart = consoleTextbox.TextLength;
            consoleTextbox.ScrollToCaret();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void githubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Astrol99/AIO");
        }

        private void attachCSGOBtn_Click(object sender, EventArgs e)
        {
            attachedStatus.Text = "True";
            attachedStatus.ForeColor = Color.Lime;
        }
    }
}
