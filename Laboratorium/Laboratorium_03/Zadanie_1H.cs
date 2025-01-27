using System;

class Book
{
    protected string Title { get; set; }
    protected Person Author { get; set; }
    protected int DataWydania { get; set; }

    public Book(string title, Person author, int dataWydania)
    {
        Title = title;
        Author = author;
        DataWydania = dataWydania;
    }

    public virtual void View()
    {
        Console.WriteLine($"Tytuł: {Title}, Autor: {Author.FirstName} {Author.LastName}, Data wydania: {DataWydania}");
    }
}
