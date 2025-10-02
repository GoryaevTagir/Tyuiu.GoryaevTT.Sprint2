using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GoryaevTT.Sprint2.Task3.V3.Lib
{
    public class Class1 : ISprint2Task3V3
    {
        public double Calculate(double x)
        {
            double ans = 0;
            if (x > 1)
            {
                ans = x * Math.Pow((x + 1) / (x - 1), x);
            }
            else if (x == 0)
            {
                ans = (Math.Pow(x, 4) - Math.Cos(Math.Pow(x, 5)) + 3) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2) + 12));
            }
            else if (x > -7 && x < 0)
            {
                ans = Math.Pow((x + Math.Sqrt(x + 3) / Math.Pow(x, 2)), x);
            }
            else if (x < -7)
            {
                ans = Math.Pow(x, 2) + 10 * x - (1 / x);
            }
            else { ans = 0; }
            return Math.Round(ans, 3);
        }
    }
}