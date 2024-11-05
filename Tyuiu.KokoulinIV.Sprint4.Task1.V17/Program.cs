using Tyuiu.KokoulinIV.Sprint4.Task1.V17.Lib;
namespace Tyuiu.KokoulinIV.Sprint4.Task1.V17
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
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Кокоулин Иван Владимирович   | ИБКСб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов                     *");
            Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 1 до 7               *");
            Console.WriteLine("* подсчитать сумму четных элементов массива.                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                  1, 7, 6, 3, 2, 5, 7, 6, 7, 6, 5, 4, 7, 6               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите количество элементов массива");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[len];
            
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Введите элемент номер " +  i);
                array[i]= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int z = ds.Calculate(array);
            Console.WriteLine(z);

            Console.ReadKey();
        }
    }
}
