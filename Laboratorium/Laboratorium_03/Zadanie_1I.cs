class AdventureBook : Book
{
    public string Region { get; private set; }

    public AdventureBook(string title, Person author, int dataWydania, string region)
        : base(title, author, dataWydania)
    {
        Region = region;
    }

    public override void View()
    {
        base.View();
        Console.WriteLine($"Region: {Region}");
    }
}

class DocumentaryBook : Book
{
    public string Topic { get; private set; }

    public DocumentaryBook(string title, Person author, int dataWydania, string topic)
        : base(title, author, dataWydania)
    {
        Topic = topic;
    }

    public override void View()
    {
        base.View();
        Console.WriteLine($"Temat: {Topic}");
    }
}

class Program
{
    static void Main()
    {
        Person author = new Person("Jan", "Kowalski", 45);
        AdventureBook advBook = new AdventureBook("Przygody w górach", author, 2022, "Tatry");
        DocumentaryBook docBook = new DocumentaryBook("Historia komputerów", author, 2021, "Informatyka");

        advBook.View();
        docBook.View();
    }
}
