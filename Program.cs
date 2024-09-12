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

//2. Feladat
Console.WriteLine("2. Feladat");
Console.WriteLine("(())".isValid());
Console.WriteLine("))((".isValid());

//3. Feladat








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
