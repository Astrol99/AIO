using System;
using System.Diagnostics;

namespace AIO
{
    class ProcessHandler
    {
        public VAMemory vam = attach();
        public int BaseClient = getModuleAddress();

        // Attach to csgo process
        private static VAMemory attach()
        {
            VAMemory vam = new VAMemory("csgo");
            if (vam.CheckProcess() == false)
            {
                Debug.Log("Failed to attach to csgo", "Red");
                return null;
            }
            else
            {
                Debug.Log("Attached to csgo", "Lime");
                Form1._Form1.attachedStatus.Text = "True";
                Form1._Form1.attachedStatus.ForeColor = System.Drawing.Color.Lime;

                Form1._Form1.attachCSGOBtn.Enabled = false;
                return vam;
            }
        }

        // Get module client_panorama.dll address of csgo process
        private static int getModuleAddress()
        {
            try
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
                            return (int)m.BaseAddress;
                        }
                    }
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            catch(Exception ex)
            {
                Debug.Log($"Error getting module address:\n{ex}", "Red");
                return 1;
            }
        }
    }
}
