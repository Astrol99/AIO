using System;
using System.IO;
using System.Windows.Forms;
using System.Net;

namespace AIO
{
    class UpdateStuff
    {
        public static void getOffsets()
        {
            // Download files from https://github.com/frk1/hazedumper

            string targetDir = Directory.GetCurrentDirectory() + "\\offsets.json";
            WebClient Client = new WebClient();
            Client.DownloadFile("https://raw.githubusercontent.com/frk1/hazedumper/master/csgo.json", @targetDir);
            MessageBox.Show("Successfully downloaded offsets in "+targetDir, "Offsets Updater", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void askUser()
        {
            // Setup messagebox properties
            String caption = "Offsets Updater";
            MessageBoxButtons btn = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;

            DialogResult result;

            // If file of offsets is present
            if (!File.Exists("offsets.json"))
            {
                result = MessageBox.Show("Offsets not found. Proceed to download offsets?", caption, btn, icon);

                // Exit program because offsets are needed
                if (result == DialogResult.No) 
                {
                    MessageBox.Show("Offsets are required to run this program! Exiting...", caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            else
            {
                result = MessageBox.Show("Offsets found. Update offsets?", caption, btn, icon);
            }

            if (result == DialogResult.Yes)
            {
                getOffsets();
            }
        }
    }
}