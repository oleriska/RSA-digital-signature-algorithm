using System.Security.Cryptography;

namespace InfoSec4Receiver
{
    public partial class Form1 : Form
    {
        public static InfoSec4.Signature receivedSignature;
        public Form1()
        {
            InitializeComponent();
            InitializeFormAsync();
            EventManager.onInformationReceived += UpdateInfo;
        }
        private async void InitializeFormAsync()
        {
            await SocketReceiver.Receive();
        }
        public void UpdateInfo()
        {
            InitialTextTB.Text = receivedSignature.PlainText;
            SignatureTB.Text = Convert.ToBase64String(receivedSignature.SignatureValue);
            EncryptedTextTB.Text = Convert.ToBase64String(receivedSignature.SignedData);
        }

        private void VerifyButton_Click(object sender, EventArgs e)
        {
            if(receivedSignature != null)
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    rsa.ImportParameters(InfoSec4.ParamParser.ListToParams(receivedSignature.SignatureParams));
                    bool verified = rsa.VerifyData(receivedSignature.SignedData, new SHA256CryptoServiceProvider(), receivedSignature.SignatureValue);
                    MessageBox.Show("Verification status: " + verified);
                }
            }
        }
    }
}