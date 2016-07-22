using System;

namespace AsterixQuadrat
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i > 1 && i < n)
                {
                    Console.Write("*" + new string(' ', n-2) + "*");
                    Console.WriteLine();                
                }
                else
                {
                    Console.WriteLine(new string('*', n) + " ");
                }
            }
           
        }
    }
}