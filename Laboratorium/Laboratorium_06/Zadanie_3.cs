using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

class PeselAnaliza
{
    public static int PoliczZenskiePESELE(string fileName)
    {
        if (!File.Exists(fileName)) return 0;
        var pesels = File.ReadAllLines(fileName);
        return pesels.Count(pesel => int.Parse(pesel.Substring(9, 1)) % 2 == 0);
    }
}