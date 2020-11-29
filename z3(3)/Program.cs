using System;

namespace z3_3_
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int[] box = new int[4];
            int a = 0;
            for (int b = 1; b <= 10; b++)
            {
                Console.WriteLine("\n{0} ящик", b);
                for (int i = 0; i < 4; i++)
                {
                    box[i] = rnd.Next(50, 100);
                    Console.Write(box[i] + "дБ ");
                    if (box[i] >= 85)
                    {
                        a++;
                    }
                }
            }
            Console.WriteLine("\nВсего Гарри Поттер собрал {0} корней мандрагоры", a);
            Console.ReadKey();
        }
    }
}
