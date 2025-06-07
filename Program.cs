using System;

namespace mod3_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4;

            Console.WriteLine("Escribe un número:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escribe un número:");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe un número:");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe un número:");
            n4 = int.Parse(Console.ReadLine());

            if (n1 < n2 && n1 < n3 && n1 < n4)
            {
                Console.WriteLine($"{n1} es el menor de los cuatro números");
            }
            else if (n2 < n3 && n2 < n4)
            {
                Console.WriteLine($"{n2} es el menor de los cuatro números");
            }
            else if (n3 < n4)
            {
                Console.WriteLine($"{n3} es el menor de los cuatro números");
            }
            else
            {
                Console.WriteLine($"{n4} es el menor de los cuatro números");
            }
        }
    }
}
