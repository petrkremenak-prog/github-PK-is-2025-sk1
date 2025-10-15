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
    Console.WriteLine("Zadali jste hodnoty první: {0}, poslední: {1}, diferenci: {2}", first, last, step);
    Console.Write("Výsledná posloupnost: ");
    for (int i = first; i <= last; i += step)
    {
        Console.Write(" {0},", i);
    }
    Console.WriteLine();
    Console.WriteLine("Pro opakování stiskněte tlačítko a: ");
    opakovani = Console.ReadLine();
}
while (opakovani == "a");