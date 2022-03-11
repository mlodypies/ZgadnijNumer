Random r = new Random();
int licz = r.Next(1, 11);
int licz2;
Console.WriteLine("Losowanie liczby 1-10");
Console.WriteLine("Sprobuj zgadnac jaka to liczba");

while (true)
{
    licz2 = Convert.ToInt32(Console.ReadLine());
    if (licz2 < licz)
    {
        Console.WriteLine("Liczba ktora wpisales jest wieksza niz wylosowana.");
        Console.WriteLine("Sprobuj jeszcze raz.");
        continue;
    }
    else
    if (licz2 > licz)
    {
        Console.WriteLine("Liczba ktora wpisales jest nizsza niz wylosowana.");
        Console.WriteLine("Sprobuj ponownie.");
        continue;

    }
    if (licz2 == licz)
    {
        Console.WriteLine("Gratuluje!");
        Console.WriteLine("Wylosowana liczba to " + licz);
        break;
        
    }
}


