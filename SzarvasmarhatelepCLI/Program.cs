﻿using SzarvasmarhatelepCLI;

const string PATH = "E:\\juhaszz\\PROJECTS\\CSHARP25020502\\SZARVASMARHATELEP\\hozam.txt";
List<Tehen> happyCows = [];

using StreamReader sr = new(PATH);

while (!sr.EndOfStream)
{
    string adatSor = sr.ReadLine();

    string id = adatSor.Split(';')[0];
    string nap = adatSor.Split(';')[1];
    string mennyiseg = adatSor.Split(';')[2];

    Tehen aktTehen = new(id);

    if (!happyCows.Contains(aktTehen))
    {
        happyCows.Add(aktTehen);
    }

    int index = happyCows.IndexOf(aktTehen);

    happyCows[index].EredmenytRogzit(nap, mennyiseg);
}

Console.WriteLine("3. feladat");
Console.WriteLine($"Az állomány {happyCows.Count} tehén adatait tartalmazza");