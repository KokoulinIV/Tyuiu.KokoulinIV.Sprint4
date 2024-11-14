using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KokoulinIV.Sprint4.Task7.V5.Lib
{
    public class DataService : ISprint4Task6V5

    {
        public int Calculate(string[] array)
        {
            
            int[,] matrx = new int[3,3];
            int r = 0;
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
               
                    matrx[i, j] = int.Parse(array[i * 3 + j ].ToString());
                    if (matrx[i, j] % 2 == 0)
                    {
                        r++;
                    }
                }
            }
            
            return r;
        }
    }
}
