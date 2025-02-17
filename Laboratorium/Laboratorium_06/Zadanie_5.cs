using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

interface IPersonRepository
{
    void AddPerson(Person person);
    List<Person> GetAllPeople();
}

class FilePersonRepository : IPersonRepository
{
    private readonly string filePath;

    public FilePersonRepository(string filePath)
    {
        this.filePath = filePath;
    }

    public void AddPerson(Person person)
    {
        string json = JsonSerializer.Serialize(person);
        File.AppendAllText(filePath, json + "\n");
    }

    public List<Person> GetAllPeople()
    {
        if (!File.Exists(filePath)) return new List<Person>();
        return File.ReadAllLines(filePath).Select(line => JsonSerializer.Deserialize<Person>(line)).ToList();
    }
}

record Person(string Name, int Age);

