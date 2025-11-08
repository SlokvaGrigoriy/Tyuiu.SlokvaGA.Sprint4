using Tyuiu.SlokvaGA.Sprint4.Task6.V15.Lib;

namespace Tyuiu.SlokvaGA.Sprint4.Task6.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var cities = new string[] { "Чикаго", "Хьюстон", "Феникс", "Филадельфия", "Сан-Антонио", "Сан-Диего", "Даллас" };
            int res = ds.Calculate(cities);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
