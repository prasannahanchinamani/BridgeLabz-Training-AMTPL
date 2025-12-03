using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training_AMTPL.DelegatesEventsClosure
{
    public class Subsriber
    {
        public void Receive()
        {
            Console.WriteLine("User received notification");
        }
    }
    internal class NotificationExample
    {
        public event Action OnNotiFy;
         public void Send(){
            Console.WriteLine("Sending Notification to user");
            OnNotiFy?.Invoke();
        }
        static void Main(string[] args)
        {
            NotificationExample example = new NotificationExample();
            Subsriber subsriber = new Subsriber();

            example.OnNotiFy += subsriber.Receive;
             example.Send();

        }

    }
}
