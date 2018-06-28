using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Game;

namespace Game.Tests
{
    [TestClass]
    public class ScrabbleScoreTest
    {
        [TestMethod]
        public void GetSetWord_GetsSetsUserWord_True()
        {
            ScrabbleScore newGame = new ScrabbleScore();
            string word = "noob";
            newGame.SetWord(word);
            Assert.AreEqual(word, newGame.GetWord());
        }

        [TestMethod]
        public void GetSetTotalScore_GetsSetsTotalScore_True()
        {
            ScrabbleScore newGame = new ScrabbleScore();
            int score = 1;
            newGame.SetTotalScore(score);
            Assert.AreEqual(score, newGame.GetTotalScore());
        }

        [TestMethod]
        public void GetSetWord_GetsSetsUserWordToLowerCase_True()
        {
            {
                ScrabbleScore newGame = new ScrabbleScore();
                newGame.SetWord("NOOB");
                Assert.AreEqual("noob", newGame.GetWord());
            }
        }
    }
}
