using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;

public class LibraryManager
{
    private List<Book> books; // Lista książek
    private List<User> users; // Lista użytkowników
    private List<Transaction> transactions; // Lista transakcji wypożyczeń
    private FileHandler fileHandler; // Obiekt obsługujący pliki CSV

    public LibraryManager()
    {
        fileHandler = new FileHandler();

        // Użycie operatora `??` dla uniknięcia przypisania wartości null
        books = fileHandler.LoadBooksFromFile("books.csv") ?? new List<Book>();
        users = fileHandler.LoadUsersFromFile("users.csv") ?? new List<User>();
        transactions = fileHandler.LoadTransactionsFromFile("transactions.csv") ?? new List<Transaction>();
    }

    // Dodawanie nowej książki do systemu
    public void AddBook(Book book)
    {
        if (book != null) // Sprawdzenie, czy book nie jest null
        {
            books.Add(book);
            fileHandler.SaveBooksToFile(books, "books.csv");
        }
    }

    // Edytowanie istniejącej książki na podstawie ID
    public void EditBook(int bookId, string newTitle, string newAuthor, int newYear)
    {
        Book? book = books.FirstOrDefault(b => b.ID == bookId); // `?` pozwala na null
        if (book != null)
        {
            book.Title = newTitle;
            book.Author = newAuthor;
            book.Year = newYear;
            fileHandler.SaveBooksToFile(books, "books.csv");
        }
        else
        {
            Console.WriteLine("Nie znaleziono książki o podanym ID.");
        }
    }

    // Usuwanie książki z katalogu bibliotecznego
    public void RemoveBook(int bookId)
    {
        Book? book = books.FirstOrDefault(b => b.ID == bookId);
        if (book != null)
        {
            books.Remove(book);
            fileHandler.SaveBooksToFile(books, "books.csv");
        }
        else
        {
            Console.WriteLine("Nie znaleziono książki o podanym ID.");
        }
    }

    // Rejestracja nowego użytkownika
    public void RegisterUser(User user)
    {
        if (user != null) // Sprawdzenie, czy user nie jest null
        {
            users.Add(user);
            fileHandler.SaveUsersToFile(users, "users.csv");
        }
    }

    // Wypożyczanie książki dla użytkownika
    public void BorrowBook(int bookId, int userId)
    {
        Book? book = books.FirstOrDefault(b => b.ID == bookId);
        if (book != null && book.IsAvailable)
        {
            book.IsAvailable = false;
            transactions.Add(new Transaction
            {
                BookID = bookId,
                UserID = userId,
                BorrowDate = DateTime.Now,
                ReturnDate = null
            });

            fileHandler.SaveBooksToFile(books, "books.csv");
            fileHandler.SaveTransactionsToFile(transactions, "transactions.csv");
        }
        else
        {
            Console.WriteLine("Książka jest niedostępna.");
        }
    }

    // Zwrot książki do biblioteki
    public void ReturnBook(int bookId, int userId)
    {
        Transaction? transaction = transactions.FirstOrDefault(t => t.BookID == bookId && t.UserID == userId && t.ReturnDate == null);
        if (transaction != null)
        {
            transaction.ReturnDate = DateTime.Now;
            Book? book = books.FirstOrDefault(b => b.ID == bookId);
            if (book != null)
            {
                book.IsAvailable = true;
            }

            fileHandler.SaveBooksToFile(books, "books.csv");
            fileHandler.SaveTransactionsToFile(transactions, "transactions.csv");
        }
        else
        {
            Console.WriteLine("Nie znaleziono transakcji wypożyczenia tej książki.");
        }
    }

    // Wyświetlanie listy książek
    public void ShowBooks()
    {
        if (books != null && books.Count > 0) // Sprawdzenie, czy lista nie jest pusta
        {
            foreach (var book in books)
            {
                Console.WriteLine($"ID: {book.ID}, Tytuł: {book.Title}, Autor: {book.Author}, Rok: {book.Year}, " +
                    $"Dostępność: {book.IsAvailable}");
            }
        }
        else
        {
            Console.WriteLine("Brak książek w systemie.");
        }
    }

    // Wyświetlanie listy użytkowników
    public void ShowUsers()
    {
        if (users != null && users.Count > 0)
        {
            foreach (var user in users)
            {
                Console.WriteLine($"ID: {user.ID}, Imię: {user.Name}, Nazwisko: {user.Surname}," +
                    $"Telefon: {user.PhoneNumber}");
            }
        }
        else
        {
            Console.WriteLine("Brak użytkowników w systemie.");
        }
    }
}
