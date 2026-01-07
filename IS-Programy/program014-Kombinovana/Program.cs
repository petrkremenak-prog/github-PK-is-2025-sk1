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
    int pocet_serazeni=0;
    int selection_index=0;
    do
    {
        int temp = 0;
        selection_index=pocet_serazeni;
        for (int i=pocet_serazeni; i<n-1; i++)
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
    }


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
    }
