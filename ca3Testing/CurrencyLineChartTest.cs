using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ca3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ca3Testing
{
    [TestClass()]
    class CurrencyLineChartTest
    {
        [TestMethod()]
        public void CurrencyLineTest_Period()
        {
            CurrencyLineChart t1 = new CurrencyLineChart();
            t1.Period = new DateTime(2021, 12, 31);

            DateTime result = new DateTime(2021, 12, 31);
            DateTime expectedResult = t1.Period;

            Assert.AreEqual(result, expectedResult);

        }

        [TestMethod()]
        public void CurrencyLineTest_Currency()
        {
            CurrencyLineChart t1 = new CurrencyLineChart();
            t1.Currency = 1.80;

            double result = 1.80;
            double expectedResult = t1.Currency;

            Assert.AreEqual(result, expectedResult);

        }


    }
}
