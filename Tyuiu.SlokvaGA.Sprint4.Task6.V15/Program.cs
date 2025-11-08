using Tyuiu.SlokvaGA.Sprint4.Task6.V15.Lib;

namespace Tyuiu.SlokvaGA.Sprint4.Task6.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Слоква Г. А. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема: Класс Array                                                      *");
            Console.WriteLine("* Задание #6                                                             *");
            Console.WriteLine("* Вариант #15                                                            *");
            Console.WriteLine("* Выполнил: Слоква Г. А. | ИСПб-25-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан строковый массив данных ['Чикаго', 'Хьюстон', 'Феникс',            *");
            Console.WriteLine("* 'Филадельфия', 'Сан-Антонио', 'Сан-Диего', 'Даллас'] используя класс   *");
            Console.WriteLine("* Array подсчитайте количество элементов, длина которых меньше 7.        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            var cities = new string[] { "Чикаго", "Хьюстон", "Феникс", "Филадельфия", "Сан-Антонио", "Сан-Диего", "Даллас" };
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= cities.Length - 1; i++)
            {
                Console.WriteLine(cities[i]);
            }

            Console.WriteLine("************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                               *");
            Console.WriteLine("************************************************************");
            Console.WriteLine("Количество элементов, длина которых < 7:");

            int n = ds.Calculate(cities);

            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
