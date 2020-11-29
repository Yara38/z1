using System;

namespace z2_2_
{
    class Program
    {
        static void Main()
        {
            int a = 0;
            int b = 0;
            for (int i = 20000; i <= 5409314; i++)
            {
                if (i % 2 == 0)
                {
                    a++;
                }
                else
                {
                    b++;
                }
            }
            Console.WriteLine("На концерт Alai Oli идут {0} человек", a);
            Console.WriteLine("На концерт Торба на круче идут {0} человек", b);
            Console.ReadKey();
        }
    }
}
