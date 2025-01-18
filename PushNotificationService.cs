using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_OOP05
{
    
    internal class PushNotificationService : INotificationService
    {
        private string? recipient;
        private string? notify ;
        public void SendNotification(string not, string mess)
        {
            recipient = not ;
            notify =  mess ;
            Console.WriteLine($"to {not} \n message : {mess}");

        }
    }
}
