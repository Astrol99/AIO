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
            debug("Downloading offsets...");
            var rawJson = getOffsets();
            debug("Done!", "Lime");
            deserializeJSON(rawJson);
            debug("Deserialized and parsed raw offsets from https://github.com/frk1/hazedumper/blob/master/csgo.json");
        }

        #region Offset Handling
        public static String getOffsets()
        {
            // Download files from https://github.com/frk1/hazedumper

            using (WebClient wc = new WebClient())
            {
                String offsetsJsonRAW = wc.DownloadString("https://raw.githubusercontent.com/frk1/hazedumper/master/csgo.json");
                return offsetsJsonRAW;
            }
        }

        public static void deserializeJSON(string rawJSON)
        {
            try
            {
                var csgoJson = JsonConvert.DeserializeObject<dynamic>(rawJSON);

                Form1.sig = csgoJson.signatures;
                Form1.netvars = csgoJson.netvars;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
