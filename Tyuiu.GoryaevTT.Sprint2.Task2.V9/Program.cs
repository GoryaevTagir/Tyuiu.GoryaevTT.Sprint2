using Tyuiu.GoryaevTT.Sprint2.Task2.V9.Lib;
namespace Tyuiu.GoryaevTT.Sprint2.Task2.V9
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Class1 ds = new Class1();
            bool res = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine(res);
        }
    }
}