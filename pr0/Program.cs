using System;

namespace pr0
{
    class Program
    {
        static int InputMoney()
        {
            int a = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите сумму: ");
                if (int.TryParse(Console.ReadLine(), out a) != true)
                {
                    Console.WriteLine(" ");
                }
                else
                {
                    return a;
                }
            }
            return a;
        }
        static void Product(int a)
        {
            string[] product = new string[] { "воду", "чай", "американо" };
            int[] price = new int[] { 40, 60, 100 };
            for (int i = 0; i < price.Length; i++)
            {
                if (a >= price[i])
                {
                    Console.WriteLine("Вы можете купить {0}", product[i]);
                }
            }
        }
        static void Main()
        {
            int a = InputMoney();
            Product(a);
            Console.ReadKey();
        }
    }
}