using System;

namespace ConsoleApp1
{
    // Klasa reprezentująca pracownika biblioteki, dziedziczy po klasie User
    public class Employee : User
    {
        // Rola pracownika w systemie (np. Pracownik, Administrator)
        public string Role { get; set; } = "Pracownik"; // Domyślna rola

        // Uprawnienia przypisane do pracownika (np. Podstawowe, Pełne)
        public string Permissions { get; set; } = "Podstawowe"; // Domyślne uprawnienia

        // Konstruktor domyślny
        public Employee()
        {
        }

        // Konstruktor inicjalizujący dane pracownika
        public Employee(string name, string surname, string role, string permissions)
        {
            Name = name;
            Surname = surname;
            Role = role;
            Permissions = permissions;
        }

        // Nadpisana metoda ToString() zwracająca sformatowane dane pracownika
        public override string ToString()
        {
            return $"{Name} {Surname}, Rola: {Role}, Uprawnienia: {Permissions}";
        }
    }
}
