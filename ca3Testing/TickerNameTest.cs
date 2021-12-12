using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ca3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;


namespace ca3Testing.Tests
{
    [TestClass()]
    public class TickerNameTest
    {
        [TestMethod()]
        public void TickerNametest_name()
        {
            TickName t1 = new TickName();
            t1.Tikr = "eur";

            String result = "eur";
            String expectedResult = t1.Tikr;

            Assert.AreEqual(result, expectedResult);

        }

        [TestMethod()]
        public void TickerCurtest_Currency()
        {
            TickName t1 = new TickName();
            t1.CurName = "euro";

            String result = "euro";
            String expectedResult = t1.CurName;

            Assert.AreEqual(result, expectedResult);

        }



    }
}
