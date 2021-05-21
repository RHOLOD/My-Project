using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Level1Space;
namespace UnitTestLevel1Space
{
    [TestClass]
    public class UnitTestBastShoe
    {
        [TestMethod]
        public void BastShoe()
        {
            Level1 level = new Level1();
            string expected = "Привет";
            string actual = level.BastShoe("1 Привет");
            Assert.AreEqual(expected, actual);
            expected = "Привет, Мир!";
            actual = level.BastShoe("1 , Мир!");
            Assert.AreEqual(expected, actual);
            expected = "Привет, Мир!++";
            actual = level.BastShoe("1 ++");
            Assert.AreEqual(expected, actual);
            expected = "Привет, Мир!";
            actual = level.BastShoe("2 2");
            Assert.AreEqual(expected, actual);
            expected = "Привет, Мир!++";
            actual = level.BastShoe("4");
            Assert.AreEqual(expected, actual);
            expected = "Привет, Мир!";
            actual = level.BastShoe("4");
            Assert.AreEqual(expected, actual);
            expected = "Привет, Мир!*";
            actual = level.BastShoe("1 *");
            Assert.AreEqual(expected, actual);
            expected = "Привет, Мир!";
            actual = level.BastShoe("4");
            Assert.AreEqual(expected, actual);
            expected = "Привет, Мир!";
            actual = level.BastShoe("4");
            Assert.AreEqual(expected, actual);
            expected = "Привет, Мир!";
            actual = level.BastShoe("4");
            Assert.AreEqual(expected, actual);
            expected = ",";
            actual = level.BastShoe("3 6");
            Assert.AreEqual(expected, actual);
            expected = "";
            actual = level.BastShoe("2 100");
            Assert.AreEqual(expected, actual);
            expected = "Привет";
            actual = level.BastShoe("1 Привет");
            Assert.AreEqual(expected, actual);
            expected = "Привет, Мир!";
            actual = level.BastShoe("1 , Мир!");
            Assert.AreEqual(expected, actual);
            expected = "Привет, Мир!++";
            actual = level.BastShoe("1 ++");
            Assert.AreEqual(expected, actual);
            expected = "Привет, Мир!";
            actual = level.BastShoe("4");
            Assert.AreEqual(expected, actual);
            expected = "Привет";
            actual = level.BastShoe("4");
            Assert.AreEqual(expected, actual);
            expected = "Привет, Мир!";
            actual = level.BastShoe("5");
            Assert.AreEqual(expected, actual);
            expected = "Привет";
            actual = level.BastShoe("4");
            Assert.AreEqual(expected, actual);
            expected = "Привет, Мир!";
            actual = level.BastShoe("5");
            Assert.AreEqual(expected, actual);
            expected = "Привет, Мир!++";
            actual = level.BastShoe("5");
            Assert.AreEqual(expected, actual);
            expected = "Привет, Мир!++";
            actual = level.BastShoe("5");
            Assert.AreEqual(expected, actual);
            expected = "Привет, Мир!++";
            actual = level.BastShoe("5");
            Assert.AreEqual(expected, actual);
            expected = "Привет, Мир!";
            actual = level.BastShoe("4");
            Assert.AreEqual(expected, actual);
            expected = "Привет";
            actual = level.BastShoe("4");
            Assert.AreEqual(expected, actual);
            expected = "Прив";
            actual = level.BastShoe("2 2");
            Assert.AreEqual(expected, actual);
            expected = "Привет";
            actual = level.BastShoe("4");
            Assert.AreEqual(expected, actual);
            expected = "Прив";
            actual = level.BastShoe("5");
            Assert.AreEqual(expected, actual);
            expected = "Прив";
            actual = level.BastShoe("5");
            Assert.AreEqual(expected, actual);
            expected = "Прив";
            actual = level.BastShoe("5");
            Assert.AreEqual(expected, actual);
        }
    }
}
