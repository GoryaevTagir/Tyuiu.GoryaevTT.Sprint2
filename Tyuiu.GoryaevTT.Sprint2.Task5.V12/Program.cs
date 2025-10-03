using Tyuiu.GoryaevTT.Sprint2.Task5.V12.Lib;
namespace Tyuiu.GoryaevTT.Sprint2.Task5.V12
{
    class Program
    {
        public static void Main(string[] args)
        {
            Class1 ds = new Class1();
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            string res = ds.FindDateOfPreviousDay(z, y, x);
            Console.WriteLine(res);
        }
    }
}