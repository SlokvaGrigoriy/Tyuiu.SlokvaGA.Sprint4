using Tyuiu.SlokvaGA.Sprint4.Task4.V15.Lib;

namespace Tyuiu.SlokvaGA.Sprint4.Task4.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.Title = "Спринт #4 | Выполнил: Слоква Г. А. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                           *");
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант #15                                                            *");
            Console.WriteLine("* Выполнил: Слоква Г. А. | ИСПб-25-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный       *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 2 до 6. Найдите сумму нечетных  *");
            Console.WriteLine("* элементов массива.                                                     *");
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
                    Console.Write($"Введите {i},{j} элемент массива: ");
                    array[i,j] = Convert.ToInt32(Console.ReadLine());
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

            Console.WriteLine("Сумма нечётных элементов = " + res);
            Console.ReadKey();
        }
    }
}
