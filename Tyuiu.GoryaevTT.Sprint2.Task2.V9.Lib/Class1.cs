using tyuiu.cources.programming.interfaces.Sprint1;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GoryaevTT.Sprint2.Task2.V9.Lib
{
    public class Class1 : ISprint2Task2V9
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool ans = false;
            if ((x >= 3 && x <= 5) || (x >= 9 && y <= 12) && (y == 3 || y == 4))
            {
                ans = true;
            }
            else if (y == 5 && (x == 4 || (x >= 8 && x<= 12)))
            {
                ans = true;
            }
            else if (y == 6 && (x == 4 || (x >= 7 && x <= 13)))
            {
                ans = true;
            }
            else if (y == 7 || y == 8 && (x == 4 || (x >= 8 && x <= 13)))
            {
                ans = true;
            }
            else if (y == 9 || y == 10 && (x == 4 || (x >= 6 && x <= 12)))
            {
                ans = true;
            }
            else if (y == 11 && (x>=3 && x <= 12))
            {
                ans = true;
            }
            else if (y == 12 && (x>=8 && x <= 10))
            {
                ans = true;
            }
            else { ans = false; }
            return ans;
        }
    }
}
