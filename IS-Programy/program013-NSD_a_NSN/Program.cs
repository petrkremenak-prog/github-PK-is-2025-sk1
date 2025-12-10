string again = "a";
while (again == "a")
{
    Console.Clear();

    // Metoda pro razítko - hlavičku
    razitko();

    // Načítání hodnot
    ulong a = nactiCislo("Zadejte číslo a: ");
    ulong b = nactiCislo("Zadejte číslo b: ");
    ulong NSD = vypocitat_NSD(a, b);
    ulong NSN = vypocitat_NSN(a, b, NSD);
    Vypis_hodnot(a, b, NSD, NSN);
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}

/* Hlavní program - konec */

/* metoda která nic nevrací - nevrací hodnotu */
static void razitko()
{
    Console.WriteLine("****************************");
    Console.WriteLine("***** Výpočet NSD a NSN *****");
    Console.WriteLine("****************************");
    Console.WriteLine("****** Křemenák Petr *******");
    Console.WriteLine("****************************");
    Console.WriteLine();
}    

/* metoda pro načtení čísel */
static ulong nactiCislo(string zprava)
{
    Console.Write(zprava);
    ulong cislo;
    while (!ulong.TryParse(Console.ReadLine(), out cislo))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte hodnotu znovu: ");
    }

    // !!! Metoda, která vrací nějaký konkrétní datový typ, musí obsahovat následující řádek
    return cislo;

}
static ulong vypocitat_NSD (ulong a, ulong b)
{
    while (a != b)
    {
        if (a > b)
        {
            a = a - b;
        }
        else
        {
            b = b - a;
        }
    }
    return a;
}
static ulong vypocitat_NSN (ulong a, ulong b, ulong NSD)
{
    return (a*b)/NSD;
}
static void Vypis_hodnot (ulong a, ulong b, ulong NSD, ulong NSN)
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("NSD čísel {0} a {1} je {2}", a, b, NSD);
    Console.WriteLine("NSN čísel {0} a {1} je {2}", a, b, NSN);
    Console.WriteLine();
}