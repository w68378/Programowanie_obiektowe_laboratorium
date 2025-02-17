using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

class OdczytPliku
{
    public static void OdczytajPlik(string fileName)
    {
        if (File.Exists(fileName))
        {
            Console.WriteLine(File.ReadAllText(fileName));
        }
        else
        {
            Console.WriteLine("Plik nie istnieje.");
        }
    }
}
