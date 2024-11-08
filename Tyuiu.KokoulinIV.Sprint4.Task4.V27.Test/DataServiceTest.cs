using Tyuiu.KokoulinIV.Sprint4.Task4.V27.Lib;
namespace Tyuiu.KokoulinIV.Sprint4.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array ={{ 4, 3, 9, 2, 2, },

                            { 8, 4, 1, 4, 3, },

                            { 3, 9, 2, 2, 5, },

                            { 4, 6, 8, 5, 6, },

                            { 1, 5, 2, 2, 5, } };
            int wail = 49;
            int res = ds.Calculate(array);
            Assert.AreEqual(wail, res);
        }
    }
}