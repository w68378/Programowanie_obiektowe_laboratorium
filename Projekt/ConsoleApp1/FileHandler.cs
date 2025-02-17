using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


// Klasa FileHandler obsługuje operacje odczytu i zapisu danych w plikach CSV.
// Przechowuje informacje o książkach, użytkownikach i transakcjach.
public class FileHandler
{
    public List<Book> LoadBooksFromFile(string filePath)
    {
        List<Book> books = new List<Book>();

        // Sprawdzenie, czy plik istnieje, zanim zostanie otwarty
        if (File.Exists(filePath))
        {
            var lines = File.ReadAllLines(filePath); // Odczytanie wszystkich linii z pliku
            foreach (var line in lines)
            {
                var parts = line.Split(','); // Podział linii na części

                // Sprawdzenie, czy linia ma odpowiednią liczbę elementów
                if (parts.Length == 5)
                {
                    books.Add(new Book
                    {
                        ID = int.Parse(parts[0]), // Unikalny identyfikator książki
                        Title = parts[1],         // Tytuł książki
                        Author = parts[2],        // Autor książki
                        Year = int.Parse(parts[3]), // Rok wydania
                        IsAvailable = bool.Parse(parts[4]) // Status dostępności
                    });
                }
            }
        }
        return books;
    }

    // Wczytuje listę użytkowników z pliku CSV.
    public List<User> LoadUsersFromFile(string filePath)
    {
        List<User> users = new List<User>();
        if (File.Exists(filePath))
        {
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length == 4)
                {
                    users.Add(new User
                    {
                        ID = int.Parse(parts[0]), // Unikalny identyfikator użytkownika
                        Name = parts[1],         // Imię użytkownika
                        Surname = parts[2],      // Nazwisko użytkownika
                        PhoneNumber = parts[3]   // Numer telefonu użytkownika
                    });
                }
            }
        }
        return users;
    }

    // Wczytuje listę transakcji z pliku CSV.
    public List<Transaction> LoadTransactionsFromFile(string filePath)
    {
        List<Transaction> transactions = new List<Transaction>();

        if (File.Exists(filePath))
        {
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(',');

                if (parts.Length == 5)
                {
                    transactions.Add(new Transaction
                    {
                        ID = int.Parse(parts[0]), // Unikalny identyfikator transakcji
                        BookID = int.Parse(parts[1]), // ID książki
                        UserID = int.Parse(parts[2]), // ID użytkownika
                        BorrowDate = DateTime.Parse(parts[3]), // Data wypożyczenia
                        ReturnDate = string.IsNullOrEmpty(parts[4]) ? (DateTime?)null : DateTime.Parse(parts[4]) // Opcjonalna data zwrotu
                    });
                }
            }
        }
        return transactions;
    }

    // Zapisuje listę książek do pliku CSV.
    public void SaveBooksToFile(List<Book> books, string filePath)
    {
        var lines = books.Select(b => $"{b.ID},{b.Title},{b.Author},{b.Year},{b.IsAvailable}");
        File.WriteAllLines(filePath, lines);
    }

    // Zapisuje listę książek do pliku CSV.
    public void SaveUsersToFile(List<User> users, string filePath)
    {
        var lines = users.Select(u => $"{u.ID},{u.Name},{u.Surname},{u.PhoneNumber}");
        File.WriteAllLines(filePath, lines);
    }

    // Zapisuje listę transakcji do pliku CSV.
    public void SaveTransactionsToFile(List<Transaction> transactions, string filePath)
    {
        var lines = transactions.Select(t => $"{t.ID},{t.BookID},{t.UserID},{t.BorrowDate},{(t.ReturnDate.HasValue ? t.ReturnDate.Value.ToString() : "")}");
        File.WriteAllLines(filePath, lines);
    }
}
