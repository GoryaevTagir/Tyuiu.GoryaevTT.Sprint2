using Tyuiu.GoryaevTT.Sprint2.Task1.V1.Lib;
namespace Tyuiu.GoryaevTT.Sprint2.Task1.V1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Class1 ds = new Class1();
            int a = 119;
            int b = 196;
            int c = 134;
            int d = 327;
            bool[] res = ds.GetLogicOperations(a, b, c, d);
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]); 
            }
        }
    }
}