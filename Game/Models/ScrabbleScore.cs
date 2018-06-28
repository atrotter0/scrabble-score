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

        public void CreateLetterScores()
        {
            _letterScores = new Dictionary<char, int>() {};
            _letterScores['a'] = 1;
            _letterScores['e'] = 1;
            _letterScores['i'] = 1;
            _letterScores['o'] = 1;
            _letterScores['u'] = 1;
            _letterScores['l'] = 1;
            _letterScores['n'] = 1;
            _letterScores['r'] = 1;
            _letterScores['s'] = 1;
            _letterScores['t'] = 1;
            _letterScores['d'] = 2;
            _letterScores['g'] = 2;
            _letterScores['b'] = 3;
            _letterScores['c'] = 3;
            _letterScores['m'] = 3;
            _letterScores['p'] = 3;
            _letterScores['f'] = 4;
            _letterScores['h'] = 4;
            _letterScores['v'] = 4;
            _letterScores['w'] = 4;
            _letterScores['y'] = 4;
            _letterScores['k'] = 5;
            _letterScores['j'] = 8;
            _letterScores['x'] = 8;
            _letterScores['q'] = 10;
            _letterScores['z'] = 10;
        }

        public int GetLetterScore(char letter)
        {
            return _letterScores[letter];
        }

        public char[] WordToLetters(string word)
        {
            char[] letters = word.ToCharArray();
            return letters;
        }
    }
}
