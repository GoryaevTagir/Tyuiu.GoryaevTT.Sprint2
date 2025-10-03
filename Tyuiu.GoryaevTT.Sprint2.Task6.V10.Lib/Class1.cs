using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GoryaevTT.Sprint2.Task6.V10.Lib
{
    public class Class1 : ISprint2Task6V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            string ans = $"{n}.{m}.{g}";
            if ((m == 2) || (m == 4) || (m == 6) || (m == 8) || (m == 9) || (m == 11))
            {
                switch (n)
                {
                    case 1:
                        n = 31;
                        m = m - 1;
                        break;
                    default:
                        n = n - 1;
                        break;

                }
            }
            else if (m == 3)
            {
                switch (n)
                {
                    case 1:
                        n = 28;
                        m = m - 1;
                        break;
                    default:
                        n = n - 1;
                        break;

                }
            }
            else if ((m == 1))
            {
                switch (n)
                {
                    case 1:
                        n = 31;
                        m = 12;
                        g = g - 1;
                        break;
                    default:
                        n = n - 1;
                        break;
                }
            }
            else
            {
                switch (n)
                {
                    case 1:
                        n = 30;
                        m = m - 1;
                        break;
                    default:
                        n = n - 1;
                        break;
                }
            }


            if ((m >= 1) && (m <= 9) && (n >= 1) && (n <= 9))
            {
                return $"0{n}.0{m}.{g}";
            }
            else if ((m >= 1) && (m <= 9))
            {
                return $"{n}.0{m}.{g}";
            }
            else if ((n >= 1) && (n <= 9))
            {
                return $"0{n}.{m}.{g}";
            }
            else
            {
                return $"{n}.{m}.{g}";
            }
        }
    }
}

