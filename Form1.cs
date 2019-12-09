using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // First things to do when window opens
        private void Form1_Load(object sender, EventArgs e)
        {
            // Check if offsets file exists
            UpdateStuff.getOffsets();
        }
    }
}
