using System;

namespace Zaytseva.Lab6.Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] Numbers;
            Numbers = new int[10];

            Random rand = new Random();
            int i, positive, negaive, nc;

            i = positive = negaive = nc = 0;

            for (i = 0; i < Numbers.Length; i++)
                Numbers[i] = rand.Next(-5, 5);

            for (i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine(Numbers[i]);

                if (Numbers[i] < 0.0)
                    nc += Numbers[i];

            }

            Console.WriteLine();

            for (i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] >= 0.0)
                    positive++;
                else
                    negaive++;
            }



            Console.WriteLine("Количество элементов массива >0  = " + positive);
            Console.WriteLine("Количество элементов массива <0  = " + negaive);
            Console.WriteLine("Сумма отрицательных элементов массива  = " + nc);
            Console.ReadLine();
        }
    }
}
