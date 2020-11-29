using System;
//Всего участвуют 4 факультета: 1.Гриффиндор, 2.Слизерин, 3.Когтевран, 4.Пуффендуй.
namespace z3_5_
{
    class Program
    {
        static void Main()
        {
            int[] a = new int[4];
            Random rnd = new Random();
            int nMin = 0;
            int min = 50;
            int nMax = 0;
            int max = 0;
            Console.WriteLine("Количество очков: ");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(0, 50);
                if (min > a[i])
                {
                    min = a[i];
                    nMin = i;
                }
                if (max < a[i])
                {
                    max = a[i];
                    nMax = i;
                }
                Console.Write(a[i] + " ");
            }
            Console.WriteLine("\nНомер выигравшего факультета: {0} \nНомер факультета с наименьшим количеством очков: {1}", nMax + 1, nMin + 1);
            Console.ReadKey();
        }
    }
}
