using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectsConstructor
{
    internal class User
    {
        public string Name { get;  }
        public string Password { get;  }
        public string Email { get; }
        public string PhoneNumber { get; }

        public User(string name, string password, string email, string phoneNumber)
        {
            Name = name;
            Password = password;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public bool IsPasswordValid()
        {
            if (Password.Length < 6)
                return false;

            bool flag = true;
            for (int i = 0; i < 10; i++)
            {
                if (Password.Contains($"{i}"))
                    flag = false;
            }

            if (flag)
                return false;

            if (Password.ToLower().Contains(Name.ToLower())) 
                return false;

            return true;
        }
    }
}
