using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_OOP05
{
    internal class EmailNotificationService : INotificationService
    {
        private string? email;
        private string? message ;
        public void SendNotification(string em , string mess)
        {
            email = em;
            message = mess;
            Console.WriteLine($"to : {em} \nmessage : {mess}");
        }
    }
}
