using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void parseStatementTest()
        {
            string statement = "1+1";
            Assert.AreEqual("2", Calculator.parseStatement(statement));
        }
    }
}