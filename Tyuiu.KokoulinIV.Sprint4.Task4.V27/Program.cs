
using Tyuiu.KokoulinIV.Sprint4.Task4.V27.Lib;
namespace Tyuiu.KokoulinIV.Sprint4.Task4.V27
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
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Кокоулин Иван Владимирович   | ИБКСб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                    *");
            Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 1 до 9.              *");
            Console.WriteLine("* Найдите сумму нечетных элементов массива.                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
         
            Console.WriteLine("Введите колличество строк");
            int str = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите колличество столбцов");
            int stl = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[str, stl];
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < stl; j++)
                {
                    Console.WriteLine($"Введите элемент массива {i},{j} ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < str; ++i)
            {
                for (int j = 0; j < stl; j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int z = ds.Calculate(array);
            Console.WriteLine(z);

            Console.ReadKey();
        }
    }
}
