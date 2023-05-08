using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05EX_TextMenager
{
    internal class TextManager
    {
        public string FindLongestWord(string sentence)
        {
            //add exeption

            string[] words = sentence.Split(' ');

            string currentLongest ="";
                foreach (string word in words)
            {
                if(word.Length> currentLongest.Length)
                {
                    currentLongest = word;
                }
                }
                return currentLongest;
        }

        public string[] FindAlllLongestWords(string sentence)
        {
            string longst = FindLongestWord(sentence);

            return FindWordsOfGivenLength(longst.Length,sentence);


        }

        private string[] FindWordsOfGivenLength(int length, string sentence)
        {
            List<string> foundWords = new List<string>();
            
            foreach (var word in sentence.Split(' '))
            {
                if (word.Length == length) 
                {
                    foundWords.Add(word);
                }
            }
            return foundWords.ToArray();
        }


    }
}
