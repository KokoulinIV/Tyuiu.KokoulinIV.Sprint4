using Tyuiu.KokoulinIV.Sprint4.Task7.V5.Lib;
namespace Tyuiu.KokoulinIV.Sprint4.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] array = { "1","2","3","4","5","6","7","8","9" };
            int wail = 4;
            int res = ds.Calculate(array);
            Assert.AreEqual(wail, res);
        }
    }
}