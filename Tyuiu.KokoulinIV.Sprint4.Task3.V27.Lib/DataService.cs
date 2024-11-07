﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KokoulinIV.Sprint4.Task3.V27.Lib
{
    public class Class1 : ISprint4Task3V27
    {
        public int Calculate(int[,] array)
        {
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] %2 == 0)
                    count++;
                }
            }
            return count;
        }
    }
}
