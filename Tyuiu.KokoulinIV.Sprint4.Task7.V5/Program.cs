﻿using Tyuiu.KokoulinIV.Sprint4.Task7.V5.Lib;
namespace Tyuiu.KokoulinIV.Sprint4.Task7.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            

            Console.Title = "Спринт #4 | Выполнил Кокоулин И. В. | ИБКСб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Кокоулин Иван Владимирович   | ИБКСб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"246813579\".                        *");
            Console.WriteLine("* Преобразуйте ее в матрицу 3 на 3 и                                      *");
            Console.WriteLine("* подсчитайте количество четных чисел.                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Строка 246813579");

            int k = 0;
            string [,] array = new string[3, 3];
            string[] arr = { "2", "4", "6", "8", "1", "3", "5", "7", "9" };
            Console.WriteLine("***************************************************************************");
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (k < 9)
                    {
                        array[i, j] = arr[k];
                        k++;
                    }
                }
            }
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int z = ds.Calculate(arr);
            Console.WriteLine(z);

            Console.ReadKey();
        }
    }
}
