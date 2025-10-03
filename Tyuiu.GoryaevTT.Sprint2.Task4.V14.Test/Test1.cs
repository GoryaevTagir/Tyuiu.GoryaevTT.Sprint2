using Tyuiu.GoryaevTT.Sprint2.Task4.V14.Lib;
namespace Tyuiu.GoryaevTT.Sprint2.Task4.V14.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 1;
            double y = 2;
            Class1 ds = new Class1();
            double res = ds.Calculate(x, y);
            Assert.AreEqual(9, res);
        }
    }
}
