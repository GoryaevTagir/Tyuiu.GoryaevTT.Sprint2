using Tyuiu.GoryaevTT.Sprint2.Task0.V18.Lib;
namespace Tyuiu.GoryaevTT.Sprint2.Task0.V23.test
{
    class Program
    {
        public static void Main(string[] args)
        {
            DataService ds = new DataService();
            bool[] res = new bool[6];
            Console.Title = "Спринт2/ выполнил Горяев Т.Т./ ПИНб-25-1";
            Console.WriteLine("Тема: Базовые навыки работы с C#");
            Console.WriteLine("Задание 0");
            Console.WriteLine("Вариант 18");
            Console.WriteLine("УСЛОВИЕ:");
            Console.WriteLine("Написать программу, которая вычисляет математическое выражение по исходным значениям данных,");
            Console.WriteLine("вводимых пользователем. Ответ округлите до 3 знаков после запятой.");
            Console.WriteLine("z = x - 10**sinx + 20x**2/3x**3 + cos(x**2 - y)");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("Введите x:");
            int x = 5105;
            Console.WriteLine("Введите y:");
            int y = 475;
            Console.WriteLine("РЕЗУЛТАТ:");
            res = ds.GetCompareOperations(x, y);

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}