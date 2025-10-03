using Tyuiu.GoryaevTT.Sprint2.Task6.V10.Lib;
namespace Tyuiu.GoryaevTT.Sprint2.Task6.V10
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
}