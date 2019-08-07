using System.Net;
using System.Net.Sockets;

namespace ChatBox
{
    public class NetworkConnect
    {
        Socket sender;
        public void Connect(string ip)
        {
            IPAddress ipAddress = IPAddress.Parse(ip);
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 11000);
            
            sender = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);
                        
            sender.Connect(ipEndPoint);
        }

        public void Disconnect()
        {
            sender.Shutdown(SocketShutdown.Both);
            sender.Close();
        }
    }
}
