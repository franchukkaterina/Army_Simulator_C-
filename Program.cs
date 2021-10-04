using System;

namespace proj
{
    class Program
    {
        static void Main(string[] args)
        {
            Soldiers.SamuraiSoldier vasya = new Soldiers.SamuraiSoldier("Goto Södziro");
            Soldiers.RomanSoldier roma = new Soldiers.RomanSoldier("Roma");

            System.Console.WriteLine(roma);
            System.Console.WriteLine(vasya);
            Console.WriteLine($"figth");
            Console.WriteLine($"figth");
            Console.WriteLine($"figth");

            roma.Atack(vasya);
            System.Console.WriteLine(roma);
            System.Console.WriteLine(vasya);

            Console.WriteLine($"figth");
            Console.WriteLine($"figth");
            Console.WriteLine($"figth");

            vasya.Atack(roma);
            System.Console.WriteLine(roma);
            System.Console.WriteLine(vasya);

        }
    }
}
