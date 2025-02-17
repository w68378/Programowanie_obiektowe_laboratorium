using System;

namespace ConsoleApp1
{
    // Klasa reprezentująca książkę w systemie bibliotecznym
    public class Book
    {
        // Unikalny identyfikator książki
        public int ID { get; set; }

        // Tytuł książki
        public string Title { get; set; } = string.Empty;

        // Autor książki
        public string Author { get; set; } = string.Empty;

        // Rok wydania książki
        public int Year { get; set; }

        // Status dostępności książki (true - dostępna, false - wypożyczona)
        public bool IsAvailable { get; set; } = true;
    }
}
