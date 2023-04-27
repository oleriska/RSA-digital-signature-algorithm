namespace InfoSec4
{
    [Serializable]
    public class Signature
    {
        private byte[] signatureValue;
        private List<byte[]> signatureParams;
        private byte[] signedData;
        private string plainText;
        public byte[] SignatureValue { get => signatureValue; set => signatureValue = value; }
        public List<byte[]> SignatureParams { get => signatureParams; set => signatureParams = value; }
        public byte[] SignedData { get => signedData; set => signedData = value; }
        public string PlainText { get => plainText; set => plainText = value; }

        public Signature()
        {
        }
    }
}
