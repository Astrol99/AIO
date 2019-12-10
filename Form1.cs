using System;
using System.Net;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AIO
{
    public partial class Form1 : Form
    {
        #region Variables

        public const string Version = "v1.2";

        // Offsets needed
        public static String rawJSON;
        public static Newtonsoft.Json.Linq.JObject sig;
        public static Newtonsoft.Json.Linq.JObject netvars;

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        // Things to run when form has loaded and displayed
        private void Form1_Shown(Object sender, EventArgs e)
        {
            // Adjust version label to correct version
            versionLabel.Text = Version;

            // Download offsets right when user launches program
            getOffsets();
        }

        #region Offset Handling

        public void getOffsets()
        {
            // Download files from https://github.com/frk1/hazedumper

            using (WebClient wc = new WebClient())
            {
                Uri url = new Uri("https://raw.githubusercontent.com/frk1/hazedumper/master/csgo.json");

                offsetsProgressbar.Maximum = 100;
                wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressChanged);
                wc.DownloadStringCompleted += new DownloadStringCompletedEventHandler(DownloadStringCompleted);
                debug("Downloading offsets...", "Yellow");
                wc.DownloadStringAsync(url);
            }
        }

        #region Download Progressbar Handlers
        void DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            debug("Done!", "Lime");
            rawJSON = e.Result;
            deserializeJSON();
        }

        void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            offsetsProgressbar.Value = offsetsProgressbar.Maximum * e.ProgressPercentage / 100;
        }
        #endregion


        public void deserializeJSON()
        {
            try
            {
                var csgoJson = JsonConvert.DeserializeObject<dynamic>(rawJSON);

                sig = csgoJson.signatures;
                netvars = csgoJson.netvars;

                debug($"TEST: timestamp -> {csgoJson.timestamp}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            debug("Deserialized and parsed raw offsets from https://github.com/frk1/hazedumper/blob/master/csgo.json");
        }


        #endregion


        #region Console Stuff
        private void debug(string text, string c = "White", bool date = true)
        {
            Color color = Color.FromName(c);
            Debug.Write(text + Environment.NewLine);

            if (date)
            {
                consoleTextbox.AppendText(DateTime.Now.ToString("[h:mm:ss tt] "));
            }
            consoleTextbox.SelectionColor = color;
            consoleTextbox.AppendText(text + Environment.NewLine);
            consoleTextbox.SelectionColor = cheatBox.ForeColor;

            consoleTextbox.ScrollToCaret();
        }
        #endregion

        #region GUI Stuff
        private void githubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Astrol99/AIO");
        }
        #endregion

        #region Main Cheat Initiation

        private void attachCSGOBtn_Click(object sender, EventArgs e)
        {
            attachedStatus.Text = "True";
            attachedStatus.ForeColor = Color.Lime;
            debug("Attached to csgo");
        }

        #endregion
    }
}
