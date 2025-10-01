using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GoryaevTT.Sprint2.Task1.V1.Lib
{
    public class Class1 : ISprint2Task1V1
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res =  new bool[6];
            res[0] = a < b | c == c;
            res[1] = d < c & c == c;
            res[2] = c == c || d > c;
            res[3] = c == c && d < c;
            res[4] = !(c != c); 
            res[5] = c == c ^ d > c;
            return res;
        }
    }
}
