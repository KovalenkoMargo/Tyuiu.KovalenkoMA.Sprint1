using Tyuiu.KovalenkoMA.Sprint1.Task5.V6.Lib;
namespace Tyuiu.KovalenkoMA.Sprint1.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 1;
            var res = ds.Calculate(k);
            Assert.AreEqual(1, res);
        }
    }
}
