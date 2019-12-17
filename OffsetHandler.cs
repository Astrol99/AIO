using System;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AIO
{
    class OffsetHandler
    {
        public static string rawJSON;

        public static int oLocalPlayer;
        public static int Health;

        public static void getOffsets()
        {
            // Download files from https://github.com/frk1/hazedumper

            using (WebClient wc = new WebClient())
            {
                Uri url = new Uri("https://raw.githubusercontent.com/frk1/hazedumper/master/csgo.json");
                
                Form1._Form1.offsetsProgressbar.Maximum = 100;
                wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressChanged);
                wc.DownloadStringCompleted += new DownloadStringCompletedEventHandler(DownloadStringCompleted);
                Debug.Log("Downloading offsets...", "Yellow");
                wc.DownloadStringAsync(url);
            }
        }

        #region Download Progressbar Handlers
        static void DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            Debug.Log("Done!", "Lime");
            rawJSON = e.Result;
            deserializeJSON();
        }

        static void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Form1._Form1.offsetsProgressbar.Value = Form1._Form1.offsetsProgressbar.Maximum * e.ProgressPercentage / 100;
        }
        #endregion


        public static void deserializeJSON()
        {
            try
            {
                var csgoJson = JsonConvert.DeserializeObject<dynamic>(rawJSON);

                oLocalPlayer = csgoJson.signatures.dwLocalPlayer;
                Health = csgoJson.netvars.m_iHealth;

                Debug.Log($"TEST: timestamp -> {csgoJson.timestamp}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Debug.Log("Deserialized and parsed raw offsets from https://github.com/frk1/hazedumper/blob/master/csgo.json");
        }
        
    }
}
