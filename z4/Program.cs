using System;

namespace z4
{
    class Program
    {
        static void outputСont(int box)
        {
            int Box = 1;
            int Cont = 1;
            int Gruz = 1;
            int a = 0;
            while (box != 0)
            {
                if (a % 324 == 0)
                {
                    Console.WriteLine("Грузовик {0}: ", Gruz);
                    Gruz++;
                }
                if (a % 27 == 0)
                {
                    Console.WriteLine("Контейнер {0}: ", Cont);
                    Cont++;
                }
                Console.WriteLine("Ящик {0}", Box);
                Box++;
                box--;
                a++;
            }
        }
        static void Main()
        {
            Console.WriteLine("Укажите количество ящиков: ");
            int box = Convert.ToInt32(Console.ReadLine());
            outputСont(box);
            Console.ReadKey();
        }
    }
}
