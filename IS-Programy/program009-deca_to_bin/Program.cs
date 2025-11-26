string opakovani = "a";
do
{
    Console.Clear();
    Console.WriteLine("****** Výpis číselných řad by Petr Křemenák ******");
     Console.Write("Zadejte první číslo v řadovém výpisu (Celé číslo): ");
    int first, last, step;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte znovu: ");
    }
    Console.Write("Zadejte poslední číslo v řadě: ");
    while (!int.TryParse(Console.ReadLine(), out last))
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte znovu: ");
    }
    Console.Write("Zadejte diferenci: ");
    while (!int.TryParse(Console.ReadLine(), out step))
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte znovu: ");
    }
    for (int i = 1; first <= last; first = first + step)
    {
        Console.WriteLine(first);
    }
    //Výpočet a vypsání posledního čísla ve dvojkové soustavě
int buffer = last;
string bin = "";

if (buffer == 0)
{
    bin = "0";
}
else
{
    while (buffer > 0)
    {
        int bit = buffer & 1;   // vezmu nejnižší bit (0 nebo 1)
        bin = bit + bin;        // přidám ho na začátek řetězce
        buffer >>= 1;           // posun doprava = dělení dvěma
    }
}

Console.WriteLine("Výpis posledního čísla ve dvojkové soustavě: " + bin);

    
    Console.WriteLine("Pro opakování stiskněte tlačítko a: ");
    opakovani = Console.ReadLine();
}
while (opakovani == "a");