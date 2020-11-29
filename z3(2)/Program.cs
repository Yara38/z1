using System;

namespace z3_2_
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 10);
            int[] code = new int[a];
            Console.WriteLine("Длинна массива: {0}", a);
            for (int i = 0; i < code.Length; i++)
            {
                code[i] = rnd.Next(-10, 10);
                Console.Write(code[i] + " ");
            }
            Console.WriteLine("\nРасшифрованный массив памяти:");
            for (int i = 0; i < code.Length; i++)
            {
                Console.Write(code[i] + 10 + " ");
            }
            Console.ReadKey();
        }
    }
}
