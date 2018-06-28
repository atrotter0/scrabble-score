using System;
using System.Collections.Generic;

namespace Game
{
    public class ScrabbleScore
    {
        private string _word = "";
        private int _totalScore = 0;
        private Dictionary<char, int> letterScores = new Dictionary<char, int>() {};

        public bool GetWord()
        {
            //return _word;
            return false;
        }

        public bool SetWord(string word)
        {
            //_word = word;
            return false;
        }
    }
}
