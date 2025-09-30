using Tyuiu.KovalenkoMA.Sprint1.Task6.V3.Lib;
namespace Tyuiu.KovalenkoMA.Sprint1.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string a = "i know that i do";
            var res = ds.LastLetterWord(a);
            Assert.AreEqual("iwtio", res);
        }
    }
}
