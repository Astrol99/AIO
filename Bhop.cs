using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.ComponentModel;

namespace AIO
{
    class Bhop
    {
        [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int GetAsyncKeyState(int vKey);

        public static int startBhop(BackgroundWorker bw)
        {
            // Setup vars
            int fJump = ProcessHandler.BaseClient + OffsetHandler.aJump;
            int aLocalPlayer = ProcessHandler.BaseClient + OffsetHandler.aLocalPlayer;
            int LocalPlayer = ProcessHandler.vam.ReadInt32((IntPtr)aLocalPlayer);
            int aFlags = LocalPlayer + OffsetHandler.oFlags;
            
            while (!bw.CancellationPending)
            {
                bool exit = false;

                // Main bhop functions
                // While space is pressed
                while (GetAsyncKeyState(32) > 0)
                {
                    // If player is jumping var
                    int Flags = ProcessHandler.vam.ReadInt32((IntPtr)aFlags);

                    // 257 = specific num when player is jumping
                    if (Flags == 257)
                    {
                        // Run jump function
                        ProcessHandler.vam.WriteInt32((IntPtr)fJump, 5);
                        Thread.Sleep(10);
                        ProcessHandler.vam.WriteInt32((IntPtr)fJump, 4);
                    }
                }

                if (exit == true)
                    break;
            }
            return 0;
        }
    }
}
