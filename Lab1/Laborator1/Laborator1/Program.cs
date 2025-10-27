    static void Main()
    {
        Console.Write("Introduceți baza initiala: ");
        int b1 = int.Parse(Console.ReadLine());
        Console.Write("Introduceți baza finala: ");
        int b2 = int.Parse(Console.ReadLine());
        Console.Write("Introduceți numărul în baza b1: ");
        string numar = Console.ReadLine().ToUpper();
        long valoare10 = ConvertToDecimal(numar, b1);
        string rezultat = ConvertFromDecimal(valoare10, b2);
        Console.WriteLine($"\nNumărul {numar} din baza {b1} este {rezultat} în baza {b2}");
    }

    static long ConvertToDecimal(string numar, int baza)
    {
        const string cifre = "0123456789ABCDEF";
        long rezultat = 0;
        foreach (char c in numar)
        {
            int valoare = cifre.IndexOf(c);
            rezultat = rezultat * baza + valoare;
        }
        return rezultat;
    }

    static string ConvertFromDecimal(long valoare, int baza)
    {
        const string cifre = "0123456789ABCDEF";
        if (valoare == 0) return "0";

        string rezultat = "";
        while (valoare > 0)
        {
            int rest = (int)(valoare % baza);
            rezultat = cifre[rest] + rezultat;
            valoare /= baza;
        }
        return rezultat;
    }
