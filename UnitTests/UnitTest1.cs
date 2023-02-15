using Microsoft.VisualStudio.TestTools.UnitTesting;
using test;
using System;
using System.Windows.Controls;
using System.Reflection;
using System.Text.RegularExpressions;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        // Тетс, который проверяет, что подсчитанное колличество балов верное
        [TestMethod]
        public void calcBonusesVarOne_Correctly()
        {
            int expected = 14;
            string[] otv = new string[17];
            otv[0] = "Pizza";
            otv[1] = "could read in English";
            otv[2] = "every week";
            otv[3] = "write a book";
            otv[4] = "True";
            otv[5] = "False";
            otv[6] = "True";
            otv[7] = "weather";
            otv[8] = "Pizza";
            otv[9] = "book";
            otv[10] = "interesting";
            otv[11] = "happy";
            otv[12] = "better";
            otv[13] = "-";
            otv[14] = "wrote";
            otv[15] = "was";
            otv[16] = "Does";
            int actual = RezultVar1.calcBonusesVarOne(otv);
            Assert.AreEqual(expected, actual);
        }
        // Тетс, который проверяет, что неправильный результат не является верным
        [TestMethod]
        public void calcBonusesVarOne_DontCorrectly()
        {
            int expected = 10;
            string[] otv = new string[17];
            otv[0] = "-";
            otv[1] = "-";
            otv[2] = "-";
            otv[3] = "write a book";
            otv[4] = "-";
            otv[5] = "-";
            otv[6] = "True";
            otv[7] = "-";
            otv[8] = "-";
            otv[9] = "book";
            otv[10] = "-";
            otv[11] = "happy";
            otv[12] = "-";
            otv[13] = "-";
            otv[14] = "wrote";
            otv[15] = "was";
            otv[16] = "Does";
            int actual = RezultVar1.calcBonusesVarOne(otv);
            Assert.AreNotEqual(expected, actual);
        }
    }
}
