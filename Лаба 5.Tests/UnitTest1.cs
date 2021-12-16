using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Лаба_5.Tests
{
    [TestClass]
    public class TableManagerTests
    {
        [TestMethod]
        public void Average_Result4()
        {
            double best_test = 4;

            Student ob = new Student("20-КБ-ПР1", "Козловска", "54455", "ЗЗНЗЗ");
            double result = ob.Average();

            Assert.AreEqual(best_test, result);
        }
    }
}
