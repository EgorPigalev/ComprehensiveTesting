using Microsoft.VisualStudio.TestTools.UnitTesting;
using test;
using System;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        // Проверка, что свойство которое хранит размер шрифта имеет ограничения на ввод слишком большого числа (не влезающий в int)
        [TestMethod]
        public void GetFontSize_BigData()
        {
            long expected = 999999999999999999;
            var tar = new Start() { s = (int)expected };
            Assert.AreEqual(expected, tar.s);
        }
        // Проверка на корректное значение
        [TestMethod]
        public void GetFontSize_Correct()
        {
            int expected = 3;
            var tar = new Start() { s = expected };
            Assert.AreEqual(expected, tar.s);
        }
        // Проверка, что свойство которое хранит размер шрифта имеет ограничения на ввод слишком маленького числа (не влезающий в int)
        [TestMethod]
        public void GetFontSize_SmallData()
        {
            long expected = -999999999999999999;
            var tar = new Start() { s = (int)expected };
            Assert.AreEqual(expected, tar.s);
        }
        // 
    }
}
