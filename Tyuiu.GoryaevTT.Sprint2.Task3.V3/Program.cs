using Tyuiu.GoryaevTT.Sprint2.Task3.V3.Lib;
class Program
{
    public static void Main(string[] args)
    {
        Class1 ds = new Class1();
        double x = Convert.ToDouble(Console.ReadLine());
        double res = ds.Calculate(x);
        Console.WriteLine(res);
    }
}