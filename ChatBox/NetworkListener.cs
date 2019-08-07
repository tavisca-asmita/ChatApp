using System.Net;
using System.Net.Sockets;

namespace ChatBox
{
    public class NetworkListener
    {
        Socket listener, socket;

        public void Accept()
        {
            socket = listener.Accept();
        }

        public void StartListening(string ipString)
        {
            IPAddress ipAddress = IPAddress.Parse(ipString);
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 11000);
            
            listener = new Socket(ipAddress.AddressFamily,
                                         SocketType.Stream,
                                         ProtocolType.Tcp);

            listener.Bind(ipEndPoint);
            listener.Listen(5);

            Accept();
            
        }

        public void StopListening()
        {
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }

    }


}
