using Tyuiu.SlokvaGA.Sprint4.Task5.V9.Lib;

namespace Tyuiu.SlokvaGA.Sprint4.Task5.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { -3, -4, 3, 4, -2 },
                                          { -2, 2, 4, -4, 4 },
                                          { 1, -4, -3, 1, 2 },
                                          { 2, -3, -1, -4, -3 },
                                          { -2, -2, 4, 3, -4 } };
            int res = ds.Calculate(mas2);
            int wait = 11;

            Assert.AreEqual(wait, res);
        }
    }
}
