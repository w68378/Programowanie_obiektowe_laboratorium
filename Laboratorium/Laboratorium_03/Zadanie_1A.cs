using System;

class Person
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public int Wiek { get; private set; }

    public Person(string firstName, string lastName, int wiek)
    {
        FirstName = firstName;
        LastName = lastName;
        Wiek = wiek;
    }

    public virtual void View()
    {
        Console.WriteLine($"Imię: {FirstName}, Nazwisko: {LastName}, Wiek: {Wiek}");
    }
}

class Book
{
    public string Title { get; private set; }
    public Person Author { get; private set; }
    public int DataWydania { get; private set; }

    public Book(string title, Person author, int dataWydania)
    {
        Title = title;
        Author = author;
        DataWydania = dataWydania;
    }

    public void View()
    {
        Console.WriteLine($"Tytuł: {Title}, Autor: {Author.FirstName} {Author.LastName}, Data wydania: {DataWydania}");
    }
}

class Program
{
    static void Main()
    {
        Person author = new Person("Jan", "Kowalski", 45);
        Book book = new Book("C# dla początkujących", author, 2023);

        author.View();
        book.View();
    }
}
