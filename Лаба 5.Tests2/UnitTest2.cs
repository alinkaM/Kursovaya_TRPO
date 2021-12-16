using Microsoft.VisualStudio.TestTools.UnitTesting;
using Лаба_5;

namespace Лаба_5.Tests2
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Average_Result5()
        {
            double best_test = 5;

            Student ob = new Student("20-КБ-ПР1", "Козловска", "55355", "ЗЗНЗЗ");
            double result = ob.Average();

            Assert.AreEqual(best_test, result);
        }
    }
}
