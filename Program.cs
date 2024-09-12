List<string> sorok = new();
sorok = File.ReadAllLines("input.txt").ToList();
int joSorokSzama = 0;
foreach (var sor in sorok)
{
    int zarokSzama = 0;
    if (sor[0] == ')')
    {

    }
    else
    {
        foreach (var betu in sor)
        {
            if (betu == '(')
            {
                zarokSzama++;
            }
            else if (betu == ')')
            {
                zarokSzama--;
            }
        }
        if (zarokSzama == 0)
        {
            joSorokSzama++;
        }
    }
}
Console.WriteLine($"1. Feladat: {joSorokSzama}");

