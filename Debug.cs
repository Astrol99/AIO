using System;
using System.Drawing;

namespace AIO
{
    class Debug
    {
        public static void Log(string text, string c = "White", bool date = true)
        {
            Color color = Color.FromName(c);
            
            if (date)
            {
                Form1._Form1.consoleTextbox.AppendText(DateTime.Now.ToString("[h:mm:ss tt] "));
            }
            Form1._Form1.consoleTextbox.SelectionColor = color;
            Form1._Form1.consoleTextbox.AppendText(text + Environment.NewLine);

            Form1._Form1.consoleTextbox.SelectionStart = Form1._Form1.consoleTextbox.TextLength;
            Form1._Form1.consoleTextbox.ScrollToCaret();
        }
    }
}
