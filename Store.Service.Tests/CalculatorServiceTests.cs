using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Store.Service.Tests
{
    [TestClass]
    public class CalculatorServiceTests
    {
        private readonly CalculatorService calculatorService = new CalculatorService();

        [TestMethod]
        public void Add()
        {
            Assert.AreEqual(6.5m, calculatorService.Add(2.5m, 4m));
        }

        [TestMethod]
        public void Subtract()
        {
            Assert.AreEqual(-1.5m, calculatorService.Subtract(2.5m, 4m));
        }
    }
}
