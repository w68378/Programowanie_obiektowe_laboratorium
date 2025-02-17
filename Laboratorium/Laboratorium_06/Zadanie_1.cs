using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

class ZapisAlbumu
{
    public static void ZapiszDoPliku(string fileName, string nrAlbumu)
    {
        File.WriteAllText(fileName, nrAlbumu);
    }
}
