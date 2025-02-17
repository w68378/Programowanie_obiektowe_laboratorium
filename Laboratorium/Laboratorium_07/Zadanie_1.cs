using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.Json;
using CsvHelper;
using System.Globalization;

class Client
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public DateTime RegistrationDate { get; set; }
}

class DatabaseManager
{
    private string connectionString = "your_connection_string_here";

    public void ExecuteQuery(string query)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
        }
    }

    public List<Client> GetClients()
    {
        List<Client> clients = new List<Client>();
        string query = "SELECT * FROM Klienci";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                clients.Add(new Client
                {
                    Id = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                    LastName = reader.GetString(2),
                    Email = reader.GetString(3),
                    Phone = reader.GetString(4),
                    RegistrationDate = reader.GetDateTime(5)
                });
            }
        }
        return clients;
    }
}

class ClientManager
{
    private DatabaseManager dbManager = new DatabaseManager();

    public void AddClient(Client client)
    {
        string query = $"INSERT INTO Klienci (FirstName, LastName, Email, Phone, RegistrationDate) VALUES ('{client.FirstName}', '{client.LastName}', '{client.Email}', '{client.Phone}', '{client.RegistrationDate}')";
        dbManager.ExecuteQuery(query);
    }

    public List<Client> GetClients()
    {
        return dbManager.GetClients();
    }
}
