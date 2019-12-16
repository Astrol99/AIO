using System;
using System.Drawing;

namespace AIO
{
    class Debug
    {
        public static void Log(Form1 frm, string text, string c = "White", bool date = true)
        {
            Color color = Color.FromName(c);
            
            if (date)
            {
                frm.consoleTextbox.AppendText(DateTime.Now.ToString("[h:mm:ss tt] "));
            }
            frm.consoleTextbox.SelectionColor = color;
            frm.consoleTextbox.AppendText(text + Environment.NewLine);

            frm.consoleTextbox.SelectionStart = frm.consoleTextbox.TextLength;
            frm.consoleTextbox.ScrollToCaret();
        }
    }
}
