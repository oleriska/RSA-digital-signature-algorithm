using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace InfoSec4
{
    public class SocketSender
    {
        public static void SendSignatureData(Signature signature)
        {
            using (TcpClient client = new TcpClient("localhost", 8888))
            {
                NetworkStream stream = client.GetStream();
                BinaryFormatter formatter = new BinaryFormatter();
                using (MemoryStream ms = new MemoryStream())
                {
                    formatter.Serialize(ms, signature);
                    byte[] buffer = ms.ToArray();
                    stream.Write(buffer, 0, buffer.Length);
                }
            }
        }
    }
}
