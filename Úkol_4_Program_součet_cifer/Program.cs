Console.Clear();
Console.Write("Zadejte číslo, u kterého chcete sčítat cifry: ");
int user_input = int.Parse(Console.ReadLine());
int sectene_cifry = 0;
while (!(user_input % 10 == 0))
    {
        sectene_cifry++;
        user_input--;
    }
while (!(user_input % 100 == 0))
{
    sectene_cifry++;
    user_input=user_input-10;    
    }
while (!(user_input % 1000 == 0))
{
    sectene_cifry++;
    user_input=user_input-100;    
    }
while (!(user_input % 10000 == 0))
{
    sectene_cifry++;
    user_input=user_input-1000;    
    }
Console.Write("Součet cifer zadaného čísla je: ");
Console.Write(sectene_cifry);
