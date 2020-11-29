using System;

namespace z2_3_
{
    class Program
    {
        static void Holiday()
        {
            int a = 500;
            for (int i = 0; i < 10; i++)
            {
                a -= 80;
                if (i < 8)
                {
                    a -= 50;
                }
                else
                {
                    a += 100;
                }
            }
            if (a < 0)
            {
                Console.WriteLine("Профессор Фарнсфорт не оплатит отпуск доктору Зойдбергу");
            }
            else
            {
                Console.WriteLine("Профессор Фарнсфорт оплатит отпуск доктору Зойдбергу");
            }
        }
        static void Main()
        {
            Holiday();
            Console.ReadKey();
        }
    }
}
