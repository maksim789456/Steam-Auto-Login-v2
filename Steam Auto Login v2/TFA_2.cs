using System;
using Google.Authenticator;
using System.Windows.Forms;
using System.Net;
using Microsoft.Win32;
using System.IO;

namespace Steam_Auto_Login_v2
{
    public partial class TFA_2 : Form
    {
        public string key;
        public TFA_2()
        {
            InitializeComponent();
            Key();
            Setup();
        }

        public void Setup()
        {
            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
            WebClient client = new WebClient();
            var setupInfo = tfa.GenerateSetupCode("SteamAutoLogin", key, 150, 150);
            textBox_manualCode.Text = setupInfo.ManualEntryKey;
            string qrUrl = setupInfo.QrCodeSetupImageUrl;
            client.DownloadFile(qrUrl, AppDomain.CurrentDomain.BaseDirectory + "qrCode.jpg");
            pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "qrCode.jpg";
        }

        public void Key()
        {
            Random rand = new Random();
            Char[] pwdChars = new Char[36] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 0; i < 10; i++)
                key += pwdChars[rand.Next(0, 35)];

            RegistryKey registryKey = Registry.CurrentUser;
            RegistryKey keyR = registryKey.CreateSubKey("Steam Auto Login");
            keyR.SetValue("key", key);
            keyR.Close();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
            bool isCorrectPin = tfa.ValidateTwoFactorPIN(key, textBox_validateCode.Text);
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
