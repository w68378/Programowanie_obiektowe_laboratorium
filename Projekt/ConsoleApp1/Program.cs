using ConsoleApp1;
using System;

class Program
{
    static void Main()
    {
        // Tworzenie obiektu LibraryManager do zarządzania biblioteką
        LibraryManager libraryManager = new LibraryManager();

        // Pętla nieskończona - program działa dopóki użytkownik nie wybierze opcji wyjścia
        while (true)
        {
            // Wyświetlenie menu głównego aplikacji
            Console.WriteLine("\n=== System Biblioteczny ===");
            Console.WriteLine("1. Dodaj książkę");
            Console.WriteLine("2. Edytuj książkę");
            Console.WriteLine("3. Usuń książkę");
            Console.WriteLine("4. Zarejestruj użytkownika");
            Console.WriteLine("5. Wypożycz książkę");
            Console.WriteLine("6. Zwróć książkę");
            Console.WriteLine("7. Wyświetl listę książek");
            Console.WriteLine("8. Wyświetl listę użytkowników");
            Console.WriteLine("9. Wyjście");
            Console.Write("Wybierz opcję: ");

            // Odczyt wyboru użytkownika i jego konwersja na liczbę
            if (!int.TryParse(Console.ReadLine(), out int choice)) continue;

            // Obsługa wyboru użytkownika poprzez instrukcję switch
            switch (choice)
            {
                case 1:
                    // Dodawanie nowej książki
                    Console.Write("Tytuł: ");
                    string title = Console.ReadLine() ?? "";
                    Console.Write("Autor: ");
                    string author = Console.ReadLine() ?? "";
                    Console.Write("Rok wydania: ");
                    if (!int.TryParse(Console.ReadLine(), out int year)) continue;

                    // Przekazanie danych do obiektu LibraryManager
                    libraryManager.AddBook(new Book { Title = title, Author = author, Year = year });
                    break;

                case 2:
                    // Edycja informacji o książce
                    libraryManager.ShowBooks(); // Wyświetlenie listy książek
                    Console.Write("Podaj ID książki do edycji: ");
                    if (!int.TryParse(Console.ReadLine(), out int editId)) continue;

                    Console.Write("Nowy tytuł: ");
                    string newTitle = Console.ReadLine() ?? "";
                    Console.Write("Nowy autor: ");
                    string newAuthor = Console.ReadLine() ?? "";
                    Console.Write("Nowy rok wydania: ");
                    if (!int.TryParse(Console.ReadLine(), out int newYear)) continue;

                    // Przekazanie zmienionych danych do metody edycji książki
                    libraryManager.EditBook(editId, newTitle, newAuthor, newYear);
                    break;

                case 3:
                    // Usuwanie książki
                    libraryManager.ShowBooks(); // Wyświetlenie listy książek
                    Console.Write("Podaj ID książki do usunięcia: ");
                    if (!int.TryParse(Console.ReadLine(), out int removeId)) continue;
                    libraryManager.RemoveBook(removeId);
                    break;

                case 4:
                    // Rejestracja nowego użytkownika
                    Console.Write("Imię: ");
                    string firstName = Console.ReadLine() ?? "";
                    Console.Write("Nazwisko: ");
                    string lastName = Console.ReadLine() ?? "";
                    Console.Write("Numer telefonu: ");
                    string phone = Console.ReadLine() ?? "";

                    // Przekazanie danych do metody rejestracji użytkownika
                    libraryManager.RegisterUser(new User { Name = firstName, Surname = lastName, PhoneNumber = phone });
                    break;

                case 5:
                    // Wypożyczanie książki
                    libraryManager.ShowBooks(); // Wyświetlenie listy książek
                    Console.Write("Podaj ID książki do wypożyczenia: ");
                    if (!int.TryParse(Console.ReadLine(), out int bookId)) continue;
                    Console.Write("Podaj ID użytkownika: ");
                    if (!int.TryParse(Console.ReadLine(), out int userId)) continue;

                    // Wywołanie metody wypożyczenia książki
                    libraryManager.BorrowBook(bookId, userId);
                    break;

                case 6:
                    // Zwrot książki
                    Console.Write("Podaj ID książki do zwrotu: ");
                    if (!int.TryParse(Console.ReadLine(), out int returnBookId)) continue;
                    Console.Write("Podaj ID użytkownika: ");
                    if (!int.TryParse(Console.ReadLine(), out int returnUserId)) continue;

                    // Wywołanie metody zwrotu książki
                    libraryManager.ReturnBook(returnBookId, returnUserId);
                    break;

                case 7:
                    // Wyświetlenie listy książek
                    libraryManager.ShowBooks();
                    break;

                case 8:
                    // Wyświetlenie listy użytkowników
                    libraryManager.ShowUsers();
                    break;

                case 9:
                    // Wyjście z programu
                    return;

                default:
                    // Obsługa nieprawidłowego wyboru
                    Console.WriteLine("Nieprawidłowy wybór.");
                    break;
            }
        }
    }
}
