﻿using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;

namespace AIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;

            _Form1 = this;
        }

        public static Form1 _Form1;

        // Things to run when form has loaded and displayed
        private void Form1_Shown(Object sender, EventArgs e)
        {
            // Download offsets right when user launches program
            OffsetHandler.getOffsets();
        }

        private void githubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Astrol99/AIO");
        }

        // Main cheat initation
        private void attachCSGOBtn_Click(object sender, EventArgs e)
        {
            ProcessHandler.attach();
            ProcessHandler.getModuleAddress();
        }


        private void DettachBtn_Click(object sender, EventArgs e)
        {
            ProcessHandler.dettach();
        }

        #region cheatWorkers
        private void bhopEnableCheckbox_CheckedChanged(object sender, EventArgs e)
        {

            if (bhopEnableCheckbox.Checked)
            {
                Debug.Log("Enabled bhop");
                this.backgroundWorker1.RunWorkerAsync();
            }
            else if (bhopEnableCheckbox.Checked == false)
            {
                this.backgroundWorker1.CancelAsync();
                Debug.Log("Disabled bhop");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;

            e.Result = Bhop.startBhop(bw);

            if (bw.CancellationPending)
            {
                e.Cancel = true;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                Debug.Log("Stopped bhop process");
            }
            else if (e.Error != null)
            {
                Debug.Log($"Bhop error:{Environment.NewLine}{e.Error.Message}", "Red");
                MessageBox.Show("An error occured: " + e.Error.Message);
                bhopEnableCheckbox.Checked = false;
            }
            else
            {
                if (e.Result.ToString() == "0")
                {
                    Debug.Log("Successfully stopped bhop");
                }
                else
                {
                    Debug.Log("Bhop stop error e.Result = " + e.Result.ToString());
                }
            }
        }
        #endregion
    }
}
