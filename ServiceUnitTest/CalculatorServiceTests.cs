using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Service.UnitTest
{
    [TestClass]
    public sealed class CalculatorServiceTests
    {
        private CalculatorService service;

        [TestInitialize]
        public void TestInitialize()
        {
            this.service = new CalculatorService();
        }

        [TestMethod]
        public void SumTest_傳入augend為10_addend為20_預期回傳30()
        {
            var augend = 10;
            var addend = 20;

            var expected = 30;

            var actual = this.service.Sum(augend, addend);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DiffrenceTest_傳入minuend為20_subtrahend為10_預期回傳10()
        {
            var minuend = 20;
            var subtrahend = 10;

            var expected = 10;

            var actual = this.service.Diffrence(minuend, subtrahend);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductTest_傳入mulitplicand為5_multiplier為3_預期回傳15()
        {
            var mulitplicand = 5;
            var multiplier = 3;

            var expected = 15;

            var actual = this.service.Product(mulitplicand, multiplier);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QuotientTest_傳入dividend為4_divisor為2_預期回傳2()
        {
            var dividend = 4;
            var divisor = 2;

            var expected = 2;

            var actual = this.service.Quotient(dividend, divisor);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QuotientTest_傳入dividend為4_divisor為0_預期回傳0()
        {
            var dividend = 4;
            var divisor = 0;

            var expected = 0;

            var actual = this.service.Quotient(dividend, divisor);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemainderTest_傳入dividend為5_divisor為4_預期回傳1()
        {
            var dividend = 5;
            var divisor = 4;

            var expected = 1;

            var actual = this.service.Remainder(dividend, divisor);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemainderTest_傳入dividend為5_divisor為0_預期回傳5()
        {
            var dividend = 5;
            var divisor = 0;

            var expected = 5;

            var actual = this.service.Remainder(dividend, divisor);

            Assert.AreEqual(expected, actual);
        }
    }
}