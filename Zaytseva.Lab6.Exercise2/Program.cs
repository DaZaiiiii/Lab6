using System;

namespace Zaytseva.Lab6.Exercise2
{
    class Program
    {

        static void Main(string[] args)
        {
            int z = 0, x = 0, max = 0;


            int[,] k = new int[10, 10]; //вводим матрицу размерами n х n
            Random r = new Random();
            Console.WriteLine();

            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    k[i, j] = r.Next(-100, 100); //придаем каждому элементу матрицы случайное значение
                    Console.Write("{0} ", k[i, j]); //выводи матрицу
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (k[i, j] > max) //находим max-элемент
                    {
                        max = k[i, j];
                        z = i + 1; //присваеваем новой переменной значение i-той строки + 1
                        x = j + 1; //присваеваем новой переменной значение j-того столбца + 1
                    }                
                }

            }
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            Console.WriteLine("Максимальный элемент матрицы равен " + max);

            Console.WriteLine();
            Console.WriteLine("Максимальный элемент находится в " + z + " строке и " + x + " столбце");
            Console.WriteLine();

            k[z - 1, x - 1] = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("{0} ", k[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
