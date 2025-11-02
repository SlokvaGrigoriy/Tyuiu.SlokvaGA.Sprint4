using Tyuiu.SlokvaGA.Sprint4.Task5.V9.Lib;

namespace Tyuiu.SlokvaGA.Sprint4.Task5.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            Console.Title = "Спринт #4 | Выполнил: Слоква Г. А. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)                   *");
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #9                                                             *");
            Console.WriteLine("* Выполнил: Слоква Г. А. | ИСПб-25-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный       *");
            Console.WriteLine("* случайными значениями в диапазоне от -4 до 4. Найти количество         *");
            Console.WriteLine("* положительных элементов.                                               *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.Write("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов в массиве: ");
            int colums = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[rows, colums];
            Console.WriteLine("**************************************************************************");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    array[i, j] = rnd.Next(-4, 4);
                }
            }

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                               *");
            Console.WriteLine("************************************************************");

            int res = ds.Calculate(array);

            Console.WriteLine("Количество положительных элементов = " + res);
            Console.ReadKey();
        }
    }
}
