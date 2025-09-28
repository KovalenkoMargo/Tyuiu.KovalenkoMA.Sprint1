using Tyuiu.KovalenkoMA.Sprint1.Task2.V29.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.KovalenkoMA.Sprint1.Task2.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 3600;
            var res = ds.ConvertSecondsToHours(x);
            Assert.AreEqual(60, res);
        }
    }
}
