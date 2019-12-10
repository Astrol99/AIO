using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace AIO
{
    public partial class Form1 : Form
    {
        public const string Version = "v1.0";

        // Offsets needed
        public static Newtonsoft.Json.Linq.JObject sig;
        public static Newtonsoft.Json.Linq.JObject netvars;

        public Form1()
        {
            InitializeComponent();
        }

        // Things to run when form has loaded and displayed
        private void Form1_Shown(Object sender, EventArgs e)
        {
            // Download offsets right when user launches program
            debug("Downloading offsets...");
            var rawJson = OffsetsHandler.getOffsets();
            debug("Done!");
            OffsetsHandler.deserializeJSON(rawJson);
            debug("Deserialized and parsed raw offsets from https://github.com/frk1/hazedumper/blob/master/csgo.json");

            // Print MOTD to console


            // Adjust version label to correct version
            versionLabel.Text = Version;
        }

        private void debug(string text)
        {
            Debug.Write(text + Environment.NewLine);
            text = DateTime.Now.ToString("[h:mm:ss tt] ") + text + Environment.NewLine;
            consoleTextbox.Text = consoleTextbox.Text + text;
            consoleTextbox.SelectionStart = consoleTextbox.TextLength;
            consoleTextbox.ScrollToCaret();
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
