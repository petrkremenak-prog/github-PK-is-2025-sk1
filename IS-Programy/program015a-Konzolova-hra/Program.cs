bool hracNaRade = true;
Console.Write("Zadejte počet sirek, s kolika chcete hrát: ");
int sirky;

while (!int.TryParse(Console.ReadLine(), out sirky) || sirky <= 0)
{
    Console.Write("Neplatný počet. Zadejte znovu: ");
}

Console.Write("Chcete hrát proti počítači (1) nebo PVP (2)? ");
bool PVP = false;
int odpoved;

do
{
    while (!int.TryParse(Console.ReadLine(), out odpoved))
    {
        Console.Write("Zadejte 1 nebo 2: ");
    }
    if (odpoved != 1 && odpoved != 2)
    {
        Console.Write("Neplatná odpověď, zadejte 1 nebo 2: ");
    }
} while (odpoved != 1 && odpoved != 2);

PVP = (odpoved == 2);

// HLAVNÍ HERNÍ SMYČKA (společná pro oba módy)
while (sirky > 0)
{
    Console.WriteLine($"\nNa stole je {sirky} sirek.");
    int tah;

    // Tah prvního hráče nebo druhého hráče v PVP
    if (hracNaRade || PVP)
    {
        string jmeno = hracNaRade ? "Hráč 1" : "Hráč 2";
        Console.Write($"{jmeno}, kolik sirek vezmeš (1, 2, 3)? ");
        
        while (!int.TryParse(Console.ReadLine(), out tah) || tah < 1 || tah > 3 || tah > sirky)
        {
            Console.Write($"Neplatný tah! Vezmi 1-3 sirky (max. {sirky}): ");
        }
    }
    else // Tah počítače (pouze pokud není PVP a není na řadě Hráč 1)
    {
        tah = new Random().Next(1, Math.Min(4, sirky + 1));
        Console.WriteLine($"Počítač vzal {tah} sirek.");
    }

    sirky -= tah;

    if (sirky <= 0)
    {
        if (PVP)
            Console.WriteLine($"Konec! {(hracNaRade ? "Hráč 2" : "Hráč 1")} vyhrává!");
        else
            Console.WriteLine(hracNaRade ? "Prohrál jsi! Zbyla na tebe poslední sirka." : "Vyhrál jsi! PC musel vzít poslední sirku.");
    }

    hracNaRade = !hracNaRade;
}