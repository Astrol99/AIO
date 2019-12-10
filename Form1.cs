using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace AIO
{
    public partial class Form1 : Form
    {
        public const string Version = "v1.1";

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
            // Print MOTD to console

            // Adjust version label to correct version
            versionLabel.Text = Version;

            // Download offsets right when user launches program
            debug("Downloading offsets...");
            var rawJson = OffsetsHandler.getOffsets();
            debug("Done!", "Lime");
            OffsetsHandler.deserializeJSON(rawJson);
            debug("Deserialized and parsed raw offsets from https://github.com/frk1/hazedumper/blob/master/csgo.json");
        }

        private void debug(string text, string c = "White")
        {
            Color color = Color.FromName(c);
            Debug.Write(text + Environment.NewLine);
            consoleTextbox.AppendText(DateTime.Now.ToString("[h:mm:ss tt] "));

            consoleTextbox.SelectionColor = color;
            consoleTextbox.AppendText(text + Environment.NewLine);
            consoleTextbox.SelectionColor = cheatBox.ForeColor;

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
            debug("Attached to csgo");
        }
    }
}
