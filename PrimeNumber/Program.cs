using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int uTal;
            int i;
            int hTal = 0; 
            int prim = 0;

            Console.Write("Skriv ett tal: ");
            uTal = int.Parse(Console.ReadLine());

            hTal = uTal / 2;

            for (i = 2 ; i <= hTal ; i++)
            {
                if (uTal % i == 0)
                {
                    prim = 1;

                    Console.Write(uTal + " är inte ett primtal.");
                    break;
                }
            }

            if (prim == 0)
                Console.Write(uTal + " är ett primtal.");

            Console.ReadLine();



        }
    }
}
