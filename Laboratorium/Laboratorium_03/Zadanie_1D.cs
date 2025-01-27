using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Person readerAsPerson = new Reader("Michał", "Wiśniewski", 35);
        Book book1 = new Book("C# dla średniozaawansowanych", new Person("Jan", "Kowalski", 45), 2023);

        if (readerAsPerson is Reader reader)
        {
            reader.DodajKsiazke(book1);
        }

        readerAsPerson.View();
    }
}
