﻿﻿string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************************");
    Console.WriteLine("***** Generátor pseudonáhodných čísel *****");
    Console.WriteLine("*******************************************");
    Console.WriteLine("*************** Tomáš Žižka ***************");
    Console.WriteLine("*******************************************");
    Console.WriteLine();
    
    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;

    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu počet čísel: ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;

    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez: ");
    }

    Console.Write("Zadejte horní mez (celé číslo): ");
    int upperBound;

    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez: ");
    }

    Console.WriteLine();
    Console.WriteLine("================================================");
    Console.WriteLine("Zadané hodnoty:");
    Console.WriteLine("Počet čísel: {0}; Dolní mez: {1}; Horní mez: {2}", n, lowerBound, upperBound);
    Console.WriteLine("================================================");

    // Deklarace pole
    int[] myRandNumbs = new int[n];

    //Random myRandNumb = new Random(50); // generování stejných čísel při stejném vstupu - hodí se pro testování
    Random myRandNumb = new Random();

    Console.WriteLine();
    Console.WriteLine("=============================================");
    Console.WriteLine("Pseudonáhodná čísla:");
    for (int i = 0; i < n ; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound+1);
        Console.Write("{0}; ", myRandNumbs[i]);
    }
    Console.WriteLine();
    int maximum = myRandNumbs[0];
    int minimum = myRandNumbs[0];
    for (int i=0; i<n-1; i++)
    {
        if (myRandNumbs[i] > maximum)
        {
            maximum = myRandNumbs[i];
        }
        else if (myRandNumbs[i] < minimum)
        {
            minimum = myRandNumbs[i];
        }
    }

    Console.WriteLine("Maximum vygenerovaných čísel je {0}", maximum);
    Console.WriteLine("Minimum vygenerovaných čísel je {0}", minimum);
    Console.WriteLine();
    Console.Write("Pozice maximálního čísla je: "); //Výpis pozic maxima
    for (int i=0; i<n-1; i++)
    {
        if (myRandNumbs[i] == maximum)
        {
            Console.Write("{0}; ", i);
        }
        else
        {
            continue;
        }
    }
    Console.WriteLine();
    Console.Write("Pozice minimálního čísla je: "); //Výpis pozic minima
    for (int i=0; i<n-1; i++)
    {
        if (myRandNumbs[i] == minimum)
        {
            Console.Write("{0}; ", i);
        }
        else
        {
            continue;
        }
    }
    /*int pocet_prohozu = 0;
    do
    {
        pocet_prohozu = 0;
        int temp = 0;
        for(int i=0; i<n-1; i++)
        {
            if (myRandNumbs[i] < myRandNumbs[i + 1])
            {
                temp = myRandNumbs[i];
                myRandNumbs[i] = myRandNumbs[i+1];
                myRandNumbs[i+1] = temp;
                pocet_prohozu++;
            }
        }
    }
    while(pocet_prohozu > 0);
    Console.WriteLine("Výpis pole po seřazení Bubble-sort");
    for (int i=0; i<n-1; i++)
    {
        Console.Write("{0}; ", myRandNumbs[i]);
    }*/
    /*int pocet_serazeni=0;
    int selection_index=0;
    do
    {
        int temp = 0;
        selection_index=pocet_serazeni;
        for (int i=pocet_serazeni; i<n; i++)
        {
            if (myRandNumbs[selection_index] < myRandNumbs[i])
            {
                selection_index = i;
            }
        }
        temp = myRandNumbs[pocet_serazeni];
        myRandNumbs[pocet_serazeni] = myRandNumbs[selection_index];
        myRandNumbs[selection_index] = temp;
        pocet_serazeni++;
    }
    while(pocet_serazeni < n);
    Console.WriteLine("Pole po seřazení selection sort");
    for (int i=0; i < n-1; i++)
    {
        Console.Write("{0}; ", myRandNumbs[i]);
    }*/
    for (int i = 0; i < myRandNumbs.Length - 1; i++)
    {
        int j = i + 1;
        int temp = myRandNumbs[j];
        while (j > 0 && temp > myRandNumbs[j - 1])
        {
            myRandNumbs[j] = myRandNumbs[j - 1];
            j--;
        }
        myRandNumbs[j] = temp;
    }
    Console.WriteLine();
    Console.Write("Pole po seřazení Insertion Sort: ");
    for (int i = 0; i < n; i++)
    {
        Console.Write("{0}; ", myRandNumbs[i]);
    }
    int druhe = 0;
    int treti = 0;
    int osme = 0;
    bool osme_existuje = false;
    bool druhe_existuje = false;
    bool treti_existuje = false;
    int p = 1;
    int median;
    for (int i = 0; i < n-1; i++)
    {
        if (myRandNumbs[i+1] < myRandNumbs[i])
        {
            p++;
        }
        if (p == 2)
        {
            druhe = myRandNumbs[i+1];
            druhe_existuje = true;
        }
        if (p == 3)
        {
            treti_existuje = true;
            treti = myRandNumbs[i+1];
        }
        if (p == 8)
        {
            osme = myRandNumbs[i+1];
            osme_existuje = true;
            break;
        }
    }
    if (n % 2 == 0)
    {
        median = (myRandNumbs[n/2]+myRandNumbs[(n/2)-1])/2;
    }
    else
    {
        median = myRandNumbs[n/2];
    }
    uint osme_copy = Convert.ToUInt32(osme);
    uint[] Osme_bin = new uint[32];
    int z;
    for (z=0; osme_copy!=0; z++)
    {
        uint zbytek = osme_copy % 2;
        osme_copy = (osme_copy/2);
        Osme_bin[z] = zbytek;
    }
    if(osme == 0)
    {
        Console.WriteLine("Osmé největší je nula");
    }
    Console.WriteLine();
    Console.Write("Binární výpis osmého největšího čísla je: ");
    for (int j = z-1; j >= 0; j--)
    {
        Console.Write("{0}", Osme_bin[j]);
    }
    Console.WriteLine();

    if (druhe_existuje){
        Console.WriteLine("Druhé největší číslo je: {0}", druhe);
    }
    else
    {
        Console.WriteLine("Druhé neexistuje");
    }
    if (treti_existuje)
    {
        Console.WriteLine("Třetí největší číslo je: {0}", treti);
    }
    else
    {
        Console.WriteLine("Třetí neexistuje");
    }
    if (osme_existuje)
    {
        Console.WriteLine("Osmé největší číslo je: {0}", osme);
    }
    else
    {
        Console.WriteLine("Osmé neexistuje");
    }
    Console.WriteLine("Medián je: {0}", median);
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
    }
