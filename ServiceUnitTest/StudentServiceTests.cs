using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System.Collections.Generic;

namespace Service.UnitTest
{
    [TestClass]
    public sealed class StudentServiceTests
    {
        private StudentService service;

        [TestInitialize]
        public void TestInitialize()
        {
            this.service = new StudentService();
        }

        [TestMethod]
        public void CalculatorBMITest_傳入學生身高為2M_體重為100KG_預期回傳25()
        {
            var student =
                new Student()
                {
                    Id = 1,
                    Name = "David",
                    Height = 2,
                    Weight = 100,
                };

            var expected = 25;

            var actual = this.service.CalculatorBMI(student);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StandardBMIPercentageTest_傳入學生集合_預期回傳75()
        {
            var students =
                new List<Student>()
                {
                    new Student()
                    {
                        Id = 3,
                        Name = "Allen",
                        Height = 2,
                        Weight = 100,
                    },
                    new Student()
                    {
                        Id = 6,
                        Name = "Echo",
                        Height = 1.8,
                        Weight = 70,
                    },
                    new Student()
                    {
                        Id = 7,
                        Name = "Peter",
                        Height = 1.9,
                        Weight = 80,
                    },
                    new Student()
                    {
                        Id = 9,
                        Name = "John",
                        Height = 2,
                        Weight = 90,
                    },
                };

            var expected = 75;

            var actual = this.service.StandardBMIPercentage(students);

            Assert.AreEqual(expected, actual);
        }
    }
}