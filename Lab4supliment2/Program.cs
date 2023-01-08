using System;

namespace Lab4supliment2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Scrie un program care afiseaza numerele de la 1 la N.
             * Daca numarul este multiplu de 3, sa se afiseze Fizz, 
             * daca este multiplu de 5 sa se afiseze Buzz,
             * daca e multiplu si de 3 si de 5 (ex: 15) sa se afiseze FizzBuzz,
             * in restul cazurilor sa se afiseze numarul*/

            Console.WriteLine("Introduceti n= ");
            int n = int.Parse(Console.ReadLine());

            string mesaj1 = "Fizz";
            string mesaj2 = "Buzz";

            for (int i=1;i<=n;i++) 
            {
                if (EsteMultipluDe3(i) && EsteMultipluDe5(i)) { Console.WriteLine("Pentru numarul " + i + " afisez " + mesaj1 + mesaj2); continue; }
                
                if (EsteMultipluDe3(i)) { Console.WriteLine("Pentru numarul " + i + " afisez " + mesaj1); continue; }
                
                if (EsteMultipluDe5(i)) { Console.WriteLine("Pentru numarul " + i + " afisez " + mesaj2); continue; }

                Console.WriteLine(i);
            }
        }

        static bool EsteMultipluDe3(int x) 
        {
            if (x % 3 == 0) return true;
            return false;
        }

        static bool EsteMultipluDe5(int x)
        {
            if (x % 5 == 0) return true;
            return false;
        }
    }
}
