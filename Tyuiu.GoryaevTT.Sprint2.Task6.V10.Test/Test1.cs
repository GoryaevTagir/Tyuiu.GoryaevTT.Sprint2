using Tyuiu.GoryaevTT.Sprint2.Task6.V10.Lib;
namespace Tyuiu.GoryaevTT.Sprint2.Task6.V10.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            int x = 1;
            int y = 1;
            int z = 1489;
            string res = ds.FindDateOfPreviousDay(z, y, x);
            string wait = "31.12.1488";
            Assert.AreEqual(wait, res);
        }
    }
}
