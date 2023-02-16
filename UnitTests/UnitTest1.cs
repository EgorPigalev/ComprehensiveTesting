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
        // Тест, который проверяет, что подсчитанное колличество баллов верное в 1 варианте
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
        // Тест, который проверяет, что неправильный результат не является верным в 1 варианте
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
        
        // Тест, который проверяет, что подсчитанное колличество баллов верное во 2 варианте
        [TestMethod]
        public void calcBonusesVarTwo_Correctly()
        {
            int expected = 15;
            string[] otv = new string[22];
            otv[0] = "A";
            otv[1] = "D";
            otv[2] = "B";
            otv[3] = "C";
            otv[4] = "ten";
            otv[5] = "on Sunday";
            otv[6] = "at 2 o'clock";
            otv[7] = "a bicycle";
            otv[8] = "books";
            otv[9] = "Post offier";
            otv[10] = "Second";
            otv[11] = "Angry";
            otv[12] = "Funnier";
            otv[13] = "Skate";
            otv[14] = "danse";
            otv[15] = "goes";
            otv[16] = "much";
            otv[17] = "a lot of";
            otv[18] = "fifteenth";
            otv[19] = "She lives in a lake.";
            otv[20] = "But most of all she likes travelling.";
            otv[21] = "Every day she travels to another lake to visit her friends Pat and Pit.";
            int actual = RezultVar2.calcBonusesVarTwo(otv);
            Assert.AreEqual(expected, actual);
        }
        // Тест, который проверяет, что неправильный результат не является верным во 2 варианте
        [TestMethod]
        public void calcBonusesVarTwo_DontCorrectly()
        {
            int expected = 14;
            string[] otv = new string[22];
            otv[0] = "A";
            otv[1] = "D";
            otv[2] = "B";
            otv[3] = "C";
            otv[4] = "ten";
            otv[5] = "on Sunday";
            otv[6] = "at 2 o'clock";
            otv[7] = "a bicycle";
            otv[8] = "books";
            otv[9] = "Post offier";
            otv[10] = "Second";
            otv[11] = "-";
            otv[12] = "-";
            otv[13] = "-";
            otv[14] = "-";
            otv[15] = "-";
            otv[16] = "-";
            otv[17] = "a lot of";
            otv[18] = "fifteenth";
            otv[19] = "-";
            otv[20] = "But most of all she likes travelling.";
            otv[21] = "Every day she travels to another lake to visit her friends Pat and Pit.";
            int actual = RezultVar2.calcBonusesVarTwo(otv);
            Assert.AreNotEqual(expected, actual);
        }
        // Тест, который проверяет, что подсчитанное колличество баллов верное в 3 варианте
        [TestMethod]
        public void calcBonusesVarThree_Correctly()
        {
            int expected = 15;
            string[] otv = new string[26];
            otv[0] = "Nina has got a brother, Nina's father's name is not Sergey, Last weekend Nina's family went to the park, Last weekend Nina's family drank tea in a cafe, Nina likes living in Moscow";
            otv[1] = "True";
            otv[2] = "False";
            otv[3] = "False";
            otv[4] = "True";
            otv[5] = "Not stated";
            otv[6] = "are";
            otv[7] = "in";
            otv[8] = "has got";
            otv[9] = "oldest";
            otv[10] = "west";
            otv[11] = "short";
            otv[12] = "cooker";
            otv[13] = "Skate";
            otv[14] = "danse";
            otv[15] = "goes";
            otv[16] = "much";
            otv[17] = "a lot of";
            otv[18] = "fifteenth";
            otv[19] = "She lives in a lake.";
            otv[20] = "But most of all she likes travelling.";
            otv[21] = "Every day she travels to another lake to visit her friends Pat and Pit.";
            int actual = RezultVar2.calcBonusesVarTwo(otv);
            Assert.AreEqual(expected, actual);
        }
        // Тест, который проверяет, что неправильный результат не является верным в 3 варианте
        [TestMethod]
        public void calcBonusesVarThree_DontCorrectly()
        {
            int expected = 14;
            string[] otv = new string[22];
            otv[0] = "A";
            otv[1] = "D";
            otv[2] = "B";
            otv[3] = "C";
            otv[4] = "ten";
            otv[5] = "on Sunday";
            otv[6] = "at 2 o'clock";
            otv[7] = "a bicycle";
            otv[8] = "books";
            otv[9] = "Post offier";
            otv[10] = "Second";
            otv[11] = "-";
            otv[12] = "-";
            otv[13] = "-";
            otv[14] = "-";
            otv[15] = "-";
            otv[16] = "-";
            otv[17] = "a lot of";
            otv[18] = "fifteenth";
            otv[19] = "-";
            otv[20] = "But most of all she likes travelling.";
            otv[21] = "Every day she travels to another lake to visit her friends Pat and Pit.";
            int actual = RezultVar2.calcBonusesVarTwo(otv);
            Assert.AreNotEqual(expected, actual);
        }
    }
}
