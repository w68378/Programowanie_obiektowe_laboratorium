using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class User
    {
        // Unikalne ID użytkownika
        public int ID { get; set; }

        // Imię użytkownika
        public string Name { get; set; } = string.Empty;

        // Nazwisko użytkownika
        public string Surname { get; set; } = string.Empty;

        // Numer telefonu użytkownika
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
