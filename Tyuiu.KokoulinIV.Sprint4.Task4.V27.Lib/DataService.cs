using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KokoulinIV.Sprint4.Task4.V27.Lib
{
    public class DataService : ISprint4Task4V27
    {
        public int Calculate(int[,] matrix)
        {
            int count = 0;
            int str = matrix.Length/ matrix.GetLength(0);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < str; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                        count += matrix[i, j];
                }
            }
            return count;
        }
    }
}
