using SzarvasmarhatelepCLI;

const string DIRPATH = "E:\\juhaszz\\PROJECTS\\CSHARP25020502\\SZARVASMARHATELEP";
List<Tehen> happyCows = [];

using StreamReader sr = new($"{DIRPATH}\\hozam.txt");

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

Console.WriteLine("6. feladat");
var joltejelok = happyCows.Where(t => t.HetiAtlag != -1);
using StreamWriter sw = new($"{DIRPATH}\\joltejelok.txt");
foreach (var tehen in joltejelok)
{
    sw.WriteLine($"{tehen.Id} {tehen.HetiAtlag}");
}
Console.WriteLine($"{joltejelok.Count()} sort írtam az állományba");