string opakovani = "a";
do
{
    int A, B, C;

    Console.Clear();
    Console.WriteLine("****** Seřažení číselných řad by Petr Křemenák ******");
    Console.Write("Zadejte první číslo ");
    while (!int.TryParse(Console.ReadLine(), out A))
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte znovu: ");
    }
    Console.Write("Zadejte druhé číslo: ");
    while (!int.TryParse(Console.ReadLine(), out B))

    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte znovu: ");
    }
    Console.Write("Zadejte třetí číslo: ");
    while (!int.TryParse(Console.ReadLine(), out C))
    
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte znovu: ");
    }
    if (A > B)
    {
        if (A > C)
        {
            Console.WriteLine("Největší číslo je A = {0}", A);
        }
        else
        {
            Console.WriteLine("Největší číslo je C = {0}", C);
        }
    }
    else if (B > C)
    {
        Console.WriteLine("Největší číslo je B = {0}", B);
    }
    else
    {
        Console.WriteLine("Největší číslo je C = {0}", C);
    }
    Console.WriteLine("Konec programu, stiskněte a pro opakování ");
    opakovani = Console.ReadLine();

} while (opakovani == "a");