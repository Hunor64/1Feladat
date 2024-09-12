using _1Feladat;
//1. Feladat

List<string> sorok = new();
sorok = File.ReadAllLines("input.txt").ToList();
int joSorokSzama = 0;
foreach (var sor in sorok)
{
    if (sor.isValid())
    {
        joSorokSzama++;
    }
}
Console.WriteLine($"1. Feladat: {joSorokSzama}");
Console.WriteLine();

//2. Feladat
Console.WriteLine("2. Feladat");
Console.WriteLine("(())".isValid());
Console.WriteLine("))((".isValid());
Console.WriteLine();

//3. Feladat
List<string> emberSorok = File.ReadAllLines("people.csv").ToList();
List<People> emberek = new();
foreach (var sor in emberSorok)
{
    emberek.Add(new People(sor));
}
Console.WriteLine("3. Feladat:");
People legFiatalabb = emberek.First(x => x.Age == emberek.Min(x => x.Age));
Console.WriteLine("Legfiatalabb személy: ");
Console.WriteLine($"{legFiatalabb.Full_Name}, {legFiatalabb.Age} éves");
Console.WriteLine("---");
People legOregebb = emberek.First(x => x.Age == emberek.Max(x => x.Age));
Console.WriteLine("Legidősebb személy: ");
Console.WriteLine($"{legOregebb.Full_Name}, {legOregebb.Age} éves");
Console.WriteLine("---");

List<int> korok = new();
foreach (var ember in emberek)
{
    korok.Add(ember.Age);
}
Console.WriteLine($"A fájlban szereplő személyek átlagos életkora: {Math.Round(korok.Average(), 2)} év.");
Console.WriteLine();

//4. Feladat
List<string> kutyaSorok = File.ReadAllLines("dogs.csv").ToList();
List<Pet> kutyak = new();
foreach (var sor in kutyaSorok)
{
    kutyak.Add(new Pet(sor));
}
People mostDogOwned = emberek.First();
foreach (var ember in emberek)
{
    if (kutyak.Count(x => x.Owner_Id == ember.ID) > kutyak.Count(x => x.Owner_Id == mostDogOwned.ID))
    {
        mostDogOwned = ember;
    }
}
Console.WriteLine("4. Feladat");
Console.WriteLine($"{mostDogOwned.Full_Name} has {kutyak.Count(x => x.Owner_Id == mostDogOwned.ID)} dogs");

//2. Feladat
static class StringExtensions
{
    public static bool isValid(this string sor)
    {
        int nyitokSzama = 0;
        int zaroSzama = 0;
        if (sor[0] == ')')
        {
            return false;
        }
        else
        {
            foreach (var betu in sor)
            {
                if (betu == '(')
                {
                    nyitokSzama++;
                }
                else
                {
                    zaroSzama++;
                }
                if (zaroSzama > nyitokSzama)
                {
                    return false;
                }
            }
            if (nyitokSzama - zaroSzama == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
