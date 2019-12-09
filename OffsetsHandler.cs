﻿using System;
using System.IO;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace AIO
{
    class OffsetsHandler
    {
        public static void getOffsets()
        {
            // Download files from https://github.com/frk1/hazedumper

            using (WebClient wc = new WebClient())
            {
                String offsetsJsonRAW = wc.DownloadString("https://raw.githubusercontent.com/frk1/hazedumper/master/csgo.json");
                deserializeJSON(offsetsJsonRAW);
            }
        }

        public static void deserializeJSON(string rawJSON)
        {
            try
            {
                var csgoJson = JsonConvert.DeserializeObject<dynamic>(rawJSON);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}