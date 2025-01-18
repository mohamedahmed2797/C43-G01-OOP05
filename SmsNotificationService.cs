using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_OOP05
{
    internal class SmsNotificationService : INotificationService
    {
        private string? recipient ;
        private string? sms ;
        public void SendNotification(string rec, string mess)
        {
             recipient = rec;
            sms = mess;
            Console.WriteLine($"to {rec} \n message : {mess}");

        }
    }
}
