using System;
using System.Collections.Generic;

abstract class Osoba
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public string Pesel { get; set; }

    public void SetFirstName(string imie) => Imie = imie;
    public void SetLastName(string nazwisko) => Nazwisko = nazwisko;
    public void SetPesel(string pesel) => Pesel = pesel;

    public int GetAge()
    {
        int year = int.Parse(Pesel.Substring(0, 2));
        year += year < 25 ? 2000 : 1900;
        return DateTime.Now.Year - year;
    }

    public string GetGender()
    {
        return int.Parse(Pesel[9].ToString()) % 2 == 0 ? "Kobieta" : "Mężczyzna";
    }

    public abstract string GetEducationInfo();
    public virtual string GetFullName() => $"{Imie} {Nazwisko}";
    public virtual bool CanGoAloneToHome() => false;
}

class Uczen : Osoba
{
    public string Szkola { get; set; }
    private bool MozeSamWracacDoDomu { get; set; }

    public void SetSchool(string szkola) => Szkola = szkola;
    public void ChangeSchool(string nowaSzkola) => Szkola = nowaSzkola;

    public void SetCanGoHomeAlone(bool pozwolenie) => MozeSamWracacDoDomu = pozwolenie;

    public override string GetEducationInfo() => $"Uczeń szkoły: {Szkola}";

    public override bool CanGoAloneToHome()
    {
        return GetAge() >= 12 || MozeSamWracacDoDomu;
    }
}

class Nauczyciel : Uczen
{
    public string TytulNaukowy { get; set; }
    public List<Uczen> PodwladniUczniowie { get; private set; } = new List<Uczen>();

    public void WhichStudentCanGoHomeAlone(DateTime dateToCheck)
    {
        Console.WriteLine($"Uczniowie, którzy mogą wracać sami do domu ({dateToCheck.ToShortDateString()}):");
        foreach (var uczen in PodwladniUczniowie)
        {
            if (uczen.CanGoAloneToHome())
            {
                Console.WriteLine($"- {uczen.GetFullName()}");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Uczen uczen1 = new Uczen
        {
            Imie = "Jan",
            Nazwisko = "Kowalski",
            Pesel = "03240512345",
            Szkola = "SP1"
        };
        Uczen uczen2 = new Uczen
        {
            Imie = "Anna",
            Nazwisko = "Nowak",
            Pesel = "12250567890",
            Szkola = "SP1"
        };
        uczen2.SetCanGoHomeAlone(true);

        Nauczyciel nauczyciel = new Nauczyciel
        {
            Imie = "Tomasz",
            Nazwisko = "Wiśniewski",
            Pesel = "80010112345",
            TytulNaukowy = "Dr"
        };

        nauczyciel.PodwladniUczniowie.Add(uczen1);
        nauczyciel.PodwladniUczniowie.Add(uczen2);

        Console.WriteLine($"Nauczyciel: {nauczyciel.GetFullName()}, Tytuł: {nauczyciel.TytulNaukowy}");
        nauczyciel.WhichStudentCanGoHomeAlone(DateTime.Now);
    }
}
