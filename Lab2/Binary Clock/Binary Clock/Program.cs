using System;
using System.Threading;
class BinaryClock 
{ 
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            DateTime acum = DateTime.Now;
            Console.WriteLine("======================================");
            Console.WriteLine("            BINARY CLOCK              ");
            Console.WriteLine("======================================");
            Console.WriteLine();
            string oreBinar = Convert.ToString(acum.Hour, 2).PadLeft(6, '0');
            string minuteBinar = Convert.ToString(acum.Minute, 2).PadLeft(6, '0');
            string secundeBinar = Convert.ToString(acum.Second, 2).PadLeft(6, '0');
            Console.WriteLine($"  ORA:     {oreBinar}  ({acum.Hour:D2})");
            Console.WriteLine($"  MINUTE:  {minuteBinar}  ({acum.Minute:D2})");
            Console.WriteLine($"  SECUNDE: {secundeBinar}  ({acum.Second:D2})");
            Console.WriteLine();
            Console.WriteLine("======================================");
            Thread.Sleep(1000);
        }
    }
}