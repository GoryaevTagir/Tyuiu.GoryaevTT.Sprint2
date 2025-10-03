using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GoryaevTT.Sprint2.Task7.V15.Lib
{
    public class Class1 : ISprint2Task7V15
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool ans = false;
            if ((Math.Pow(x, 2) + Math.Pow(y, 2) >= 1) && (Math.Pow(x, 2) + Math.Pow(y, 2) <= 4) && (y>=0))
            {
                ans = true;
            }
            return ans;
        }
    }
}
