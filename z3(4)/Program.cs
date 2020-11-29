using System;

namespace z3_4_
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 10);
            int[] b = new int[a];
            int sum = 0;
            Console.WriteLine("Массы компонентов: ");
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = rnd.Next(1, 20);
                sum += b[i];
                Console.Write(b[i] + "г ");
            }
            Console.WriteLine("\nМасса зелья {0}г", sum);
            Console.ReadKey();
        }
    }
}
