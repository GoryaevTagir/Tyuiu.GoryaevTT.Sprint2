using Tyuiu.GoryaevTT.Sprint2.Task7.V15.Lib;
namespace Tyuiu.GoryaevTT.Sprint2.Task7.V15.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            double x = 1;
            double y = 0;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, res);
        }
    }
}
