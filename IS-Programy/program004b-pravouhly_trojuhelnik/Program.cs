string opakovani = "a";
do
{
    Console.Clear();
    int výška, šířka;
    Console.Write("Zadejte Výšku (přirozené číslo): ");
    while (!int.TryParse(Console.ReadLine(), out výška))
    {
        Console.WriteLine("Nezadali jste přirozené číslo. Zadejte znovu: ");
    }
    Console.Write("Zadejte Šířku (přirozené číslo): ");
    while (!int.TryParse(Console.ReadLine(), out šířka))
    {
        Console.WriteLine("Nezadali jste přirozené číslo. Zadejte znovu: ");
    }
    for (int i = 0; i < výška; i++)
    {
        for (int z = 0; z < šířka; z++)
        {
            Console.Write(" *");
            if (z >= i)
            {
                break;
            }
        }
        Console.WriteLine();
    }














    Console.WriteLine("Pro opakování stiskněte tlačítko a: ");
    opakovani = Console.ReadLine();
}
while (opakovani == "a");
