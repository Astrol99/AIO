using System;
using System.IO;
using System.Windows.Forms;

namespace AIO
{
    class UpdateStuff
    {
        public static void getOffsets()
        {
            String caption = "Offsets Updater";
            MessageBoxButtons btn = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;

            // If file of offsets is present
            if (!File.Exists("csgo.json"))
            {
                var result = MessageBox.Show("Offsets not found. Proceed to download offsets?", caption, btn, icon);
                if (result == DialogResult.No) 
                {
                    MessageBox.Show("Offsets are required to run this program! Exiting...", caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            else
            {
                var result = MessageBox.Show("Offsets found. Update offsets?", caption, btn, icon);
            }
        }
    }
}