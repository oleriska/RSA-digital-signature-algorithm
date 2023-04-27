using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;

namespace InfoSec4Receiver
{
    public class SocketReceiver
    {
        public static async Task Receive()
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 8888);
            listener.Start();
            using (TcpClient client = await listener.AcceptTcpClientAsync())
            {
                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[client.ReceiveBufferSize];
                int bytesRead = await stream.ReadAsync(buffer, 0, client.ReceiveBufferSize);
                BinaryFormatter formatter = new BinaryFormatter();
                using (MemoryStream ms = new MemoryStream(buffer, 0, bytesRead))
                {
                    Form1.receivedSignature = (InfoSec4.Signature)formatter.Deserialize(ms);
                    EventManager.InformationReceived();
                }
            }
        }
    }
}
