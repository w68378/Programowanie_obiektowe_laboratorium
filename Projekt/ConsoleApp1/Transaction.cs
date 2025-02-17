using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Transaction
    {
        // Unikalne ID transakcji
        public int ID { get; set; }

        // ID książki, która została wypożyczona
        public int BookID { get; set; }

        // ID użytkownika, który wypożyczył książkę
        public int UserID { get; set; }

        // Data wypożyczenia książki
        public DateTime BorrowDate { get; set; }

        // Data zwrotu książki (może być null, jeśli książka nie została jeszcze zwrócona)
        public DateTime? ReturnDate { get; set; }
    }
}
