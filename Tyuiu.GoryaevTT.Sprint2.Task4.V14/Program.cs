using Tyuiu.GoryaevTT.Sprint2.Task4.V14.Lib;
namespace Tyuiu.GoryaevTT.Sprint2.Task4.V14
{
    class Program
    {
        public static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Class1 ds = new Class1();
            double res = ds.Calculate(x, y);
            Console.WriteLine(res);
        }
    }
}