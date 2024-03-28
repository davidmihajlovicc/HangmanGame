using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    public class Hangman
    {
        private string word;
        private StringBuilder answer;
        private int lives;
        public string Word { get { return word; } }
        public int Lives { get { return lives; } }

        public Hangman(string word) {
            this.word = word;
            lives = 5;
            answer = new StringBuilder();
            foreach (char letter in word) {
                answer.Append("_");
            }
        }

        public bool ContainsLetter(char letter) {
            
            return word.Contains(letter);

        }

        public void AddLetter(char letter) {
            
            for (int i = 0; i < word.Length; i++) {
                if (letter == word[i]) {
                    answer[i]=letter;
                }
            }
            
        }
        public void ReduceLives() {
            lives--;
        }

        public bool LetterUsedAlready(char letter) {
            if (answer.ToString().Contains(letter)) {
                return true;
            }
            return false;
            
        }

        public bool WordGuessed() {
            if (answer.ToString() == word) {
                return true;
            }
            return false;
        
        }

        public override string ToString()
        {
            return answer.ToString(); 
        }


    }
}
