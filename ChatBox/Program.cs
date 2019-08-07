using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ChatBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    
    public class Conversation 
    {
        
        public void Display()
        {
            Display display = new Display();
            //display.DisplayMessage(Message, Message);
        }
    }

    public class User
    {
        NetworkConnect networkConnect;
        string message;
        public void SetMessage()
        {
            message = Console.ReadLine();
        }

        public string GetMessage()
        {
            return message;
        }

        public void Connect()
        {
            networkConnect = new NetworkConnect();
            networkConnect.Connect("172.16.5.187");
        }

        public void Disconnect()
        {
            networkConnect.Disconnect();
        }
    }

    
}
