
    static void Main()
    {
        Console.Write("Introduceți baza sursă (b1, între 2 și 16): ");
        int b1 = int.Parse(Console.ReadLine());
        Console.Write("Introduceți baza destinație (b2, între 2 și 16): ");
        int b2 = int.Parse(Console.ReadLine());
        Console.Write("Introduceți numărul în baza b1: ");
        string numar = Console.ReadLine().ToUpper();
        string[] parti = numar.Split('.');
        string parteIntreaga = parti[0];
        string parteFractionara = (parti.Length > 1) ? parti[1] : "";
        long valoareIntreaga = ConvertToDecimal(parteIntreaga, b1);
        double valoareFractionara = ConvertFractionToDecimal(parteFractionara, b1);
        double valoareTotala = valoareIntreaga + valoareFractionara;
        string rezultat = ConvertFromDecimal(valoareIntreaga, b2);
        string rezultatFrac = ConvertFractionFromDecimal(valoareFractionara, b2, 10);

        if (rezultatFrac != "")
            rezultat += "." + rezultatFrac;

        Console.WriteLine($"\nRezultatul în baza {b2} este: {rezultat}");
    }
    static long ConvertToDecimal(string numar, int baza)
    {
        const string cifre = "0123456789ABCDEF";
        long rezultat = 0;

        foreach (char c in numar)
        {
            int valoare = cifre.IndexOf(c);
            if (valoare < 0 || valoare >= baza)
            {
                Console.WriteLine("Cifră invalidă pentru baza sursă!");
                Environment.Exit(1);
            }
            rezultat = rezultat * baza + valoare;
        }

        return rezultat;
    }
    static double ConvertFractionToDecimal(string fractie, int baza)
    {
        const string cifre = "0123456789ABCDEF";
        double rezultat = 0.0;
        double putere = 1.0 / baza;

        foreach (char c in fractie)
        {
            int valoare = cifre.IndexOf(c);
            if (valoare < 0 || valoare >= baza)
            {
                Console.WriteLine("Cifră invalidă în partea fracționară!");
                Environment.Exit(1);
            }
            rezultat += valoare * putere;
            putere /= baza;
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
    static string ConvertFractionFromDecimal(double fractie, int baza, int precizie)
    {
        const string cifre = "0123456789ABCDEF";
        string rezultat = "";

        for (int i = 0; i < precizie && fractie > 0; i++)
        {
            fractie *= baza;
            int cifra = (int)fractie;
            rezultat += cifre[cifra];
            fractie -= cifra;
        }

        return rezultat;
    }

