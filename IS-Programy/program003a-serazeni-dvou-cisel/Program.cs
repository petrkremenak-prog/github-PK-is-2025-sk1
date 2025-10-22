string opakovani = "a";
do
{
    int A, B;
    int temp = 0;
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
    if (B > A)
    {
        temp = A;
        A = B;
        B = temp;
    }
    else
    {
        break;
    }
    Console.WriteLine("Seřazená čísla (od největšího po nejmenší) je: {0}, {1})", A, B);
    Console.WriteLine("Konec programu, stiskněte tlačítko a pro opakování ");
    opakovani = Console.ReadLine();

} while (opakovani == "a");
