using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_OOP05
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private string name = "mohamed";
        private string password = "pota123";
        private string role = "Admin";
        public bool AuthenticateUser(string username , string password)
        {
            if (username == name && password == this.password)
            {
                Console.WriteLine("authentication done successfully");
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AuthorizeUser(string username, string role)
        {
            if (username == name && role == this.role)
            {
                Console.WriteLine("Authorization done successfully");

                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
