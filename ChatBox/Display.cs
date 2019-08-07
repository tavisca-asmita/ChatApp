namespace ChatBox
{
    public class Display 
    {
        public string DisplayMessage(string sent, string received)
        {
            if (sent.Length == 0)
                return received;
            else
                return ("   " + sent);
            
        }
    }        
}
