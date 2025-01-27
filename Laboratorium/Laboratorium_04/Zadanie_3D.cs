using System;

interface IOsoba
{
    string Imie { get; set; }
    string Nazwisko { get; set; }
    string ZwrocPelnaNazwe();
}

interface IStudent : IOsoba
{
    string Uczelnia { get; set; }
    string Kierunek { get; set; }
    int Rok { get; set; }
    int Semestr { get; set; }

    string ZwrocInformacjeOUczelni();
}

class Student : IStudent
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public string Uczelnia { get; set; }
    public string Kierunek { get; set; }
    public int Rok { get; set; }
    public int Semestr { get; set; }

    public string ZwrocPelnaNazwe() => $"{Imie} {Nazwisko}";

    public string ZwrocInformacjeOUczelni()
    {
        return $"Student: {ZwrocPelnaNazwe()}, Kierunek: {Kierunek}, Rok: {Rok}, Semestr: {Semestr}, Uczelnia: {Uczelnia}";
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student
        {
            Imie = "Jan",
            Nazwisko = "Kowalski",
            Uczelnia = "Politechnika Warszawska",
            Kierunek = "Informatyka",
            Rok = 2,
            Semestr = 4
        };

        Console.WriteLine(student.ZwrocInformacjeOUczelni());
    }
}
