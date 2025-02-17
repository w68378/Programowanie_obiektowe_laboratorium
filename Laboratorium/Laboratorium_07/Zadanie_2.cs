using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.Json;
using CsvHelper;
using System.Globalization;

class CsvClientManager
{
    private string filePath = "clients.csv";

    public void SaveClients(List<Client> clients)
    {
        using (var writer = new StreamWriter(filePath))
        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
            csv.WriteRecords(clients);
        }
    }

    public List<Client> LoadClients()
    {
        if (!File.Exists(filePath)) return new List<Client>();
        using (var reader = new StreamReader(filePath))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            return csv.GetRecords<Client>().ToList();
        }
    }
}

class Program
{
    static void Main()
    {
        ClientManager clientManager = new ClientManager();
        CsvClientManager csvClientManager = new CsvClientManager();

        Console.WriteLine("1. Dodaj klienta do bazy danych");
        Console.WriteLine("2. Wyświetl klientów z bazy danych");
        Console.WriteLine("3. Dodaj klienta do pliku CSV");
        Console.WriteLine("4. Wyświetl klientów z pliku CSV");
        Console.WriteLine("5. Wyjście");

        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            Client newClient = new Client
            {
                FirstName = "Jan",
                LastName = "Kowalski",
                Email = "jan.kowalski@example.com",
                Phone = "123456789",
                RegistrationDate = DateTime.Now
            };
            clientManager.AddClient(newClient);
        }
        else if (choice == 2)
        {
            var clients = clientManager.GetClients();
            foreach (var client in clients)
            {
                Console.WriteLine($"{client.Id} - {client.FirstName} {client.LastName}");
            }
        }
        else if (choice == 3)
        {
            Client newClient = new Client
            {
                Id = 3,
                FirstName = "Piotr",
                LastName = "Nowak",
                Email = "piotr.nowak@example.com",
                Phone = "987654321",
                RegistrationDate = DateTime.Now
            };
            var clients = csvClientManager.LoadClients();
            clients.Add(newClient);
            csvClientManager.SaveClients(clients);
        }
        else if (choice == 4)
        {
            var clients = csvClientManager.LoadClients();
            foreach (var client in clients)
            {
                Console.WriteLine($"{client.Id} - {client.FirstName} {client.LastName}");
            }
        }
    }
}