using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SlokvaGA.Sprint4.Task5.V9.Lib
{
    public class DataService : ISprint4Task5V9
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int colums = array.Length / rows;

            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (array[i, j] > 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
