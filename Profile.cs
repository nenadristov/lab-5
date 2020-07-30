using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    struct Profile
    {
        private string username;
        private string password;
        private string emailAddress;

        public Profile(string username, string emailAddress, string password)
        {
            this.username = username;
            this.password = password;
            this.emailAddress = emailAddress;
        }

        public void ChangePassword(string currentPassword, string newPassword)
        {
            if (currentPassword == password)
            {
                password = newPassword;
                Console.WriteLine("The password has been successfully changed");
                
            }
            else
            {
                Console.WriteLine("Wrong password! You don't have access to change the password");
            }
        }

        public override string ToString()
        {
            Console.WriteLine($"User name: {username}\ne-mail : {emailAddress}\nPassword: CLASSIFIED");
            return $"User name: {username}\ne-mail : {emailAddress}\nPassword: CLASSIFIED";
        }
    }
}

