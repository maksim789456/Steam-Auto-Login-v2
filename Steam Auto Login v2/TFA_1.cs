﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steam_Auto_Login_v2
{
    public partial class TFA_1 : Form
    {
        public TFA_1()
        {
            InitializeComponent();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            Hide();
            TFA_2 tfa_2 = new TFA_2();
            tfa_2.ShowDialog();
            this.Close();
        }

            //string url = "";
            //WebClient client = new WebClient();
            //client.DownloadFile(url, AppDomain.CurrentDomain.BaseDirectory + "qrCode.jpg");

        private void buttonNo_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.tfaOn = false;
            Properties.Settings.Default.Save();
            Hide();
            FirstStart firstStart = new FirstStart();
            firstStart.ShowDialog();
            this.Close();
        }
    }
}