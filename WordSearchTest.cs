using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Level1Space;

namespace Level1SpaceTest
{
    [TestClass]
    public class WordSearchTest
    {
        [TestMethod]
        public void TestWordSearch1()
        {
            string s = "1) stroka razbivaetsya na nabor strok cherez vyravnivanie po zadannoj shirine.";
            string subs = "strok";
            int len = 12;
            int[] expected = new int[7] { 0, 0, 0, 1, 0, 0, 0 };

            Level1 level = new Level1();
            int[] actual = level.WordSearch(len,s,subs);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestWordSearch2()
        {
            string s = "12345";
            string subs = "45";
            int len = 3;
            int[] expected = new int[2] { 0, 1 };

            Level1 level = new Level1();
            int[] actual = level.WordSearch(len, s, subs);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestWordSearch3()
        {
            string s = "1) строка разбивается на набор строк через выравнивание по заданной ширине.";
            string subs = "строк";
            int len = 12;
            int[] expected = new int[7] { 0, 0, 0, 1, 0, 0, 0 };

            Level1 level = new Level1();
            int[] actual = level.WordSearch(len, s, subs);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
