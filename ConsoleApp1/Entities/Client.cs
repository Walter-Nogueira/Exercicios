using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    internal class Client
    {
        public string Nome { get; set; }
        public string Email { get; set; } 
        DateTime DateTime { get; set; }

        public Client()
        {

        }
        public Client(string nome, string email, DateTime dateTime)
        {
            Nome = nome;
            Email = email;
            DateTime = dateTime;
        }
    }
}
