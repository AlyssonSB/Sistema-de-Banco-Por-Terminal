using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course;

namespace Course.Entities

{
    class Account
    {
        public Account() { }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Number { get; set; }
        public double Balance { get; set; }
        public string Address { get; set; }

        public Account(string name, string email, string address, int number)
        {
            Name = name;
            Email = email;
            Address = address; 
            Number = number; 
            Balance = 0;
        }

        public string Grande(string name, string email)
        {
            return name + email;
        }
    }
}
