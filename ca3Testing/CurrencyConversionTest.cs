using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ca3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ca3Testing.Tests
{
    [TestClass()]
    public class CurrencyConversionTest
    {
        [TestMethod()]
        public void CurrencyConversiontest_name()
        {
            Currencycon t1 = new Currencycon();
            t1.CoinName = "eur";

            String result = "eur";
            String expectedResult = t1.CoinName;

            Assert.AreEqual(result, expectedResult);

        }

        [TestMethod()]
        public void CurrencyConversiontest_Currency()
        {
            Currencycon t1 = new Currencycon();
            t1.CoinAmount = "1.80";

            String result = "1.80";
            String expectedResult = t1.CoinAmount;

            Assert.AreEqual(result, expectedResult);

        }
    }
}
