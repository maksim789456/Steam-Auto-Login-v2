using System;
using Google.Authenticator;
using System.Windows.Forms;
using System.Net;
using System.IO;

//Copyright © maksim789456  2017

namespace Steam_Auto_Login_v2
{
    public partial class TFA_2 : Form
    {
        public TFA_2()
        {
            InitializeComponent();
            Setup();
        }

        public void Setup()
        {
            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
            WebClient client = new WebClient();
            var setupInfo = tfa.GenerateSetupCode("SteamAutoLogin", Program.KeyG.key, 150, 150);
            textBox_manualCode.Text = setupInfo.ManualEntryKey;
            string qrUrl = setupInfo.QrCodeSetupImageUrl;
            client.DownloadFile(qrUrl, AppDomain.CurrentDomain.BaseDirectory + "qrCode.jpg");
            pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "qrCode.jpg";
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
            bool isCorrectPin = tfa.ValidateTwoFactorPIN(Program.KeyG.key, textBox_validateCode.Text);
            if (isCorrectPin == true)
            {
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + "qrCode.jpg");
                Hide();
                FirstStart firstStart = new FirstStart();
                firstStart.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Неправильный код");
        }
    }
}
