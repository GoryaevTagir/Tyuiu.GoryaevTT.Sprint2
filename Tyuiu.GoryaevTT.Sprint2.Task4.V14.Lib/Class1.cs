using tyuiu.cources.programming.interfaces.Sprint1;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GoryaevTT.Sprint2.Task4.V14.Lib
{
    public class Class1 : ISprint2Task4V14
    {
        public double Calculate(double x, double y)
        {
            double ans = x*3 < Math.Sqrt(y) + 20? (ans = Math.Pow(2 + 1 / Math.Pow(x, 2), y)) : (ans = (Math.Pow(y, 2)-Math.Cos(Math.Pow(x,2)) + 10)/(Math.Pow(x, 2) - Math.Sin(Math.Pow(y,2)) +12));
            return ans;
        }
    }
}
