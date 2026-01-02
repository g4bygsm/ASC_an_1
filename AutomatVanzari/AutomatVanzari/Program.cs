using System;
using System.Security;

class AutomatVanzari
{
    static void Main()
    {
        int currentState = 0;
        int products = 0;
        int price = 20;
        Console.WriteLine("=== Automat de Vanzari ===");
        Console.WriteLine("Pret produs - 20 Centi");
        Console.WriteLine("Introdu: 5(Nickel), 10(Dime), 25(Quarter)");
        Console.WriteLine();
        while (true)
        {
            Console.WriteLine($"\nIn automat ai {currentState} centi.");
            Console.WriteLine("Introdu Moneda:");
            string input = Console.ReadLine();
            int moneda = int.Parse(input);
            currentState = currentState + moneda;

            if(currentState >= price)
            {
                int change = currentState - price;
                products++;
                Console.WriteLine();
                Console.WriteLine($"Produsul nr.{products} eliberat!");
                Console.WriteLine($"Rest: {change} centi");
                Console.WriteLine("====================================");
                currentState = 0;
            }
            else
            {
                Console.WriteLine("Mai adauga sefule...");
            }
        }
    }
}