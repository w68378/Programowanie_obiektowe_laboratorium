using System;

class Samochod
{
    public string Marka { get; private set; }
    public string Model { get; private set; }
    public string Nadwozie { get; private set; }
    public string Kolor { get; private set; }
    public int RokProdukcji { get; private set; }
    public int Przebieg { get; private set; }

    public Samochod(string marka, string model, string nadwozie, string kolor, int rokProdukcji, int przebieg)
    {
        if (przebieg < 0)
            throw new ArgumentException("Przebieg nie może być ujemny.");

        Marka = marka;
        Model = model;
        Nadwozie = nadwozie;
        Kolor = kolor;
        RokProdukcji = rokProdukcji;
        Przebieg = przebieg;
    }

    public Samochod()
    {
        Console.Write("Podaj markę: ");
        Marka = Console.ReadLine();
        Console.Write("Podaj model: ");
        Model = Console.ReadLine();
        Console.Write("Podaj typ nadwozia: ");
        Nadwozie = Console.ReadLine();
        Console.Write("Podaj kolor: ");
        Kolor = Console.ReadLine();
        Console.Write("Podaj rok produkcji: ");
        RokProdukcji = int.Parse(Console.ReadLine());
        Console.Write("Podaj przebieg (km): ");
        Przebieg = int.Parse(Console.ReadLine());

        if (Przebieg < 0)
            throw new ArgumentException("Przebieg nie może być ujemny.");
    }

    public virtual void View()
    {
        Console.WriteLine($"Samochód: {Marka} {Model}, Nadwozie: {Nadwozie}, Kolor: {Kolor}, Rok: {RokProdukcji}, Przebieg: {Przebieg} km");
    }
}

class SamochodOsobowy : Samochod
{
    public double Waga { get; private set; }
    public double PojemnoscSilnika { get; private set; }
    public int IloscOsob { get; private set; }

    public SamochodOsobowy(string marka, string model, string nadwozie, string kolor, int rokProdukcji, int przebieg, double waga, double pojemnoscSilnika, int iloscOsob)
        : base(marka, model, nadwozie, kolor, rokProdukcji, przebieg)
    {
        if (waga < 2 || waga > 4.5)
            throw new ArgumentException("Waga musi być w przedziale 2-4.5 tony.");
        if (pojemnoscSilnika < 0.8 || pojemnoscSilnika > 3.0)
            throw new ArgumentException("Pojemność silnika musi być w przedziale 0.8-3.0.");

        Waga = waga;
        PojemnoscSilnika = pojemnoscSilnika;
        IloscOsob = iloscOsob;
    }

    public SamochodOsobowy() : base()
    {
        Console.Write("Podaj wagę (t): ");
        Waga = double.Parse(Console.ReadLine());
        Console.Write("Podaj pojemność silnika (l): ");
        PojemnoscSilnika = double.Parse(Console.ReadLine());
        Console.Write("Podaj liczbę osób: ");
        IloscOsob = int.Parse(Console.ReadLine());

        if (Waga < 2 || Waga > 4.5)
            throw new ArgumentException("Waga musi być w przedziale 2-4.5 tony.");
        if (PojemnoscSilnika < 0.8 || PojemnoscSilnika > 3.0)
            throw new ArgumentException("Pojemność silnika musi być w przedziale 0.8-3.0.");
    }

    public override void View()
    {
        base.View();
        Console.WriteLine($"Waga: {Waga} t, Pojemność silnika: {PojemnoscSilnika} l, Ilość osób: {IloscOsob}");
    }
}

class Program
{
    static void Main()
    {
        Samochod auto1 = new Samochod("Toyota", "Corolla", "Sedan", "Czarny", 2020, 50000);
        Samochod auto2 = new Samochod();

        SamochodOsobowy osobowy = new SamochodOsobowy("Audi", "A4", "Sedan", "Czerwony", 2022, 20000, 2.5, 2.0, 5);

        auto1.View();
        auto2.View();
        osobowy.View();
    }
}
