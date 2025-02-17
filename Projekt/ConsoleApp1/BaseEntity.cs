using System;

namespace ConsoleApp1
{
    // Klasa bazowa dla wszystkich encji w systemie
    public abstract class BaseEntity
    {
        // Unikalny identyfikator obiektu
        public int ID { get; set; }

        // Data i czas utworzenia obiektu, domyślnie ustawiona na bieżący czas
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Data i czas ostatniej aktualizacji obiektu, domyślnie ustawiona na bieżący czas
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
