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
            ScrabbleScore newGame = new ScrabbleScore();
            newGame.SetWord("NOOB");
            Assert.AreEqual("noob", newGame.GetWord());
        }

        [TestMethod]
        public void GetCreateLetterScore_CreatesAndGetsLetterScore_True()
        {
            ScrabbleScore newGame = new ScrabbleScore();
            newGame.CreateLetterScores();
            Assert.AreEqual(1, newGame.GetLetterScore('n'));
        }

        [TestMethod]
        public void WordToLetters_TurnsWordIntoLetters_True()
        {
            ScrabbleScore newGame = new ScrabbleScore();
            newGame.SetWord("noob");
            char[] wordSplit = { 'n', 'o', 'o', 'b' };
            CollectionAssert.AreEqual(wordSplit, newGame.WordToLetters(newGame.GetWord()));
        }

        [TestMethod]
        public void SumScore_SumsValueOfLettersInWord_Int()
        {
            ScrabbleScore newGame = new ScrabbleScore();
            newGame.SetWord("noob");
            newGame.SumScore();
            Assert.AreEqual(6, newGame.GetTotalScore());
        }
    }
}
