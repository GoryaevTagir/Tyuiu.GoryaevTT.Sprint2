using Tyuiu.GoryaevTT.Sprint2.Task7.V15.Lib;
namespace Tyuiu.GoryaevTT.Sprint2.Task7.V15
{
    class Program
    {
        public static void Main(string[] args)
        {
            Class1 ds = new Class1();
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            bool res = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine(res);
        }
    }
}