using System.Security.Cryptography;
using System.Text;

namespace InfoSec4
{
    public partial class Form1 : Form
    {
        Signature currentSignatureData;
        public Form1()
        {
            InitializeComponent();
        }

        private void SignButton_Click(object sender, EventArgs e)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                byte[] data = Encoding.UTF8.GetBytes(InitialTextTB.Text);
                byte[] signature = rsa.SignData(data, new SHA256CryptoServiceProvider());
                RSAParameters publicKey = rsa.ExportParameters(false);
                rsa.ImportParameters(publicKey);

                Signature signedData = new Signature();
                signedData.SignedData = data;
                signedData.SignatureValue = signature;
                signedData.SignatureParams = ParamParser.ParamsToList(publicKey);
                signedData.PlainText = InitialTextTB.Text;
                currentSignatureData = signedData;
            }
            SignatureTB.Text = Convert.ToBase64String(currentSignatureData.SignatureValue);
            SignedTB.Text = Convert.ToBase64String(currentSignatureData.SignedData);
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if(currentSignatureData != null)
            {
                SocketSender.SendSignatureData(currentSignatureData);
            }
        }
    }
}