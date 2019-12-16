using System;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AIO
{
    class OffsetHandler
    {
        
        public static ProgressBar offsetsProgressbar = Application.OpenForms["Form1"].Controls["offsetsProgressbar"] as ProgressBar;

        public static string rawJSON;

        public static int oLocalPlayer;
        public static int Health;

        public static void getOffsets()
        {
            // Download files from https://github.com/frk1/hazedumper

            using (WebClient wc = new WebClient())
            {
                Uri url = new Uri("https://raw.githubusercontent.com/frk1/hazedumper/master/csgo.json");
                
                offsetsProgressbar.Maximum = 100;
                wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressChanged);
                wc.DownloadStringCompleted += new DownloadStringCompletedEventHandler(DownloadStringCompleted);
                Debug.Log(Form1._Form1, "Downloading offsets...", "Yellow");
                wc.DownloadStringAsync(url);
            }
        }

        #region Download Progressbar Handlers
        static void DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            Debug.Log(Form1._Form1, "Done!", "Lime");
            rawJSON = e.Result;
            deserializeJSON();
        }

        static void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            offsetsProgressbar.Value = offsetsProgressbar.Maximum * e.ProgressPercentage / 100;
        }
        #endregion


        public static void deserializeJSON()
        {
            try
            {
                var csgoJson = JsonConvert.DeserializeObject<dynamic>(rawJSON);

                oLocalPlayer = csgoJson.signatures.dwLocalPlayer;
                Health = csgoJson.netvars.m_iHealth;

                Debug.Log(Form1._Form1, $"TEST: timestamp -> {csgoJson.timestamp}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Debug.Log(Form1._Form1, "Deserialized and parsed raw offsets from https://github.com/frk1/hazedumper/blob/master/csgo.json");
        }
        
    }
}
