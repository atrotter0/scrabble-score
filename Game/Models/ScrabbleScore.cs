using System;
using System.Collections.Generic;

namespace Game
{
    public class ScrabbleScore
    {
        private string _word = "";
        private int _totalScore = 0;
        private Dictionary<char, int> letterScores = new Dictionary<char, int>() {};

        public string GetWord()
        {
            return _word;
        }

        public void SetWord(string word)
        {
            _word = word;
        }
    }
}
