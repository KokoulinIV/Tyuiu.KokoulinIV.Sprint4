using Tyuiu.KokoulinIV.Sprint4.Task6.V29.Lib;
namespace Tyuiu.KokoulinIV.Sprint4.Task6.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] array = ["Весна", "Лето", "Осень", "Зима"];
            int wail = 2;
            int res = ds.Calculate(array);
            Assert.AreEqual(wail, res);
        }
    }
}