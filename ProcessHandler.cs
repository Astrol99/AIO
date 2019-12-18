using System;
using System.Diagnostics;

namespace AIO
{
    class ProcessHandler
    {
        public static VAMemory vam;
        public static int BaseClient;

        // Attach to csgo process
        public static void attach()
        {
            vam = new VAMemory("csgo");
            if (vam.CheckProcess() == false)
            {
                Debug.Log("Failed to attach to csgo", "Red");
            }
            else
            {
                // Logging that program has sucessfully attached to csgo
                Debug.Log("Attached to csgo", "Lime");
                Form1._Form1.attachedStatus.Text = "True";
                Form1._Form1.attachedStatus.ForeColor = System.Drawing.Color.Lime;

                // Disable Attach Button
                Form1._Form1.attachCSGOBtn.Enabled = false;
                Form1._Form1.attachCSGOBtn.Visible = false;

                // Enable Dettach Button
                Form1._Form1.DettachBtn.Enabled = true;
                Form1._Form1.DettachBtn.Visible = true;

            }
        }

        // Dettach to csgo process
        public static void dettach()
        {
            // Stop cheats
            Form1._Form1.backgroundWorker1.CancelAsync();

            // Make vam var into nothing
            vam = null;

            // Log stuff
            Debug.Log("Dettached to csgo", "Lime");
            Form1._Form1.attachedStatus.Text = "False";
            Form1._Form1.attachedStatus.ForeColor = System.Drawing.Color.Red;

            // Enable Attach Button
            Form1._Form1.attachCSGOBtn.Enabled = true;
            Form1._Form1.attachCSGOBtn.Visible = true;

            // Disable Dettach Button
            Form1._Form1.DettachBtn.Enabled = false;
            Form1._Form1.DettachBtn.Visible = false;

        }

        // Get module client_panorama.dll address of csgo process
        public static void getModuleAddress()
        {
            if (vam.CheckProcess())
            {
                Process[] p = Process.GetProcessesByName("csgo");

                if (p.Length > 0)
                {
                    Debug.Log("Finding process module...");
                    foreach (ProcessModule m in p[0].Modules)
                    {
                        if (m.ModuleName == "client_panorama.dll")
                        {
                            Debug.Log($"Found target: client_panorama.dll -> 0x{m.BaseAddress}", "Lime");
                            BaseClient = (int)m.BaseAddress;
                        }
                    }
                }
            }
            else
            {
                Debug.Log("Failed to get module address", "Red");
                return;
            }
        }
    }
}
