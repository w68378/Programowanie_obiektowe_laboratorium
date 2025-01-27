using System;

class BankAccount
{
    public string Wlasciciel { get; private set; }
    public decimal Saldo { get; private set; }

    public BankAccount(string wlasciciel, decimal saldo)
    {
        Wlasciciel = wlasciciel;
        Saldo = saldo;
    }

    public void Wplata(decimal kwota)
    {
        if (kwota <= 0)
            throw new ArgumentException("Kwota musi być większa od zera.");
        Saldo += kwota;
    }

    public void Wyplata(decimal kwota)
    {
        if (kwota <= 0)
            throw new ArgumentException("Kwota musi być większa od zera.");
        if (kwota > Saldo)
            throw new InvalidOperationException("Brak wystarczających środków.");
        Saldo -= kwota;
    }
}
