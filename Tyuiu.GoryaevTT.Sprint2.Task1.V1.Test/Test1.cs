using Tyuiu.GoryaevTT.Sprint2.Task1.V1.Lib;
namespace Tyuiu.GoryaevTT.Sprint2.Task1.V1.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool[] top = new bool[6] { true, false, true, false, true, false };
            Class1 ds = new Class1();
            int a = 119;
            int b = 196;
            int c = 134;
            int d = 327;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            CollectionAssert.AreEqual(top, res);
        }
    }
}
