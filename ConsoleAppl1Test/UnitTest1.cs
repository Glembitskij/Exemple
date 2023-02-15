using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace ConsoleAppl1Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Summing10Plus5Retyrn15()
        {
            // Arrenge 
            int a = 10;
            int b = 5;
            int expected = 15;
            int actyalresult;
            Calculator calculator = new Calculator();

            // Act
            actyalresult = calculator.Summing(a, b);

            // Assert
            Assert.AreEqual(expected, actyalresult);
        }
    }
}
