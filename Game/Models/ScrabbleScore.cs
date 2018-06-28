using System;
using System.Collections.Generic;

namespace Game
{
    public class ScrabbleScore
    {
        private string _word = "";
        private int _totalScore = 0;
        private Dictionary<char, int> _letterScores = new Dictionary<char, int>() {};

        public string GetWord()
        {
            return _word;
        }

        public void SetWord(string word)
        {
            word = word.ToLower();
            _word = word;
        }

        public int GetTotalScore()
        {
            return _totalScore;
        }

        public void SetTotalScore(int score)
        {
            _totalScore += score;
        }

        public void CreateDictionary()
        {
            // _letterScores = new Dictionary<char, int>() {};
            // _letterScores['a'];
        }
    }
}
