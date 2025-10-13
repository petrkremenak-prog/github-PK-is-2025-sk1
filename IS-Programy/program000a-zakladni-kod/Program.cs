string opakovani = "a";
do
{
    Console.Clear();
    Console.WriteLine("****** Výpis číselných řad by Petr Křemenák ******");
    /* Console.Write("Zadejte první číslo v řadovém výpisu: ");
     int first = int.Parse(Console.ReadLine()); Takhle ne
    Console.Write("Zadejte poslední číslo v řadě: ");
    int last = int.Parse(Console.ReadLine());
    Console.Write("Zadejte diferenci: ");
    int step = int.Parse(Console.ReadLine());*/
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
    Console.WriteLine("Pro opakování stiskněte tlačítko a: ");
    opakovani = Console.ReadLine();
}
while (opakovani == "a");
