Console.Clear();
Console.WriteLine("****** Program na součet cifer ******")
Console.WriteLine("*********** Petr Křemenák ***********")
Console.Write("Zadejte číslo, u kterého chcete sčítat cifry: ");
if (!long.TryParse(Console.ReadLine(), out long n))
{
    Console.WriteLine("Neplatný vstup.");
    return;
}
long x = Math.Abs(n);
int soucet = 0;

if (x == 0) soucet = 0; // pro vstup 0

while (x > 0)
{
    soucet += (int)(x % 10);
    x /= 10;
}
Console.WriteLine($"Součet cifer zadaného čísla je: {soucet}");