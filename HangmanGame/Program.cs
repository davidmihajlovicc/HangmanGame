namespace HangmanGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            List<string> words = new List<string>() {
                "account", "across", "amusement", "beautiful", "belief",
                "brother", "cheese", "cloud", "damage", "daughter", "electric",
                "experience", "feather",  "fixed", "government", "hanging", "healthy",
                "instrument", "journey", "language", "living", "material",
                "mountain", "normal", "observation", "parallel", "political",
                "reaction", "representative", "servant", "sister", "tendency",
                "thought", "weather", "winter", "Android"
            };

            Hangman hangman = new Hangman(words[generator.Next(words.Count)]);
            Console.WriteLine("Guess the word!");
            Console.WriteLine($"Word is {hangman.Word.Length} letters long. {hangman.Word}");
            char letter;

            do
            {
                if (hangman.WordGuessed())
                {
                    Console.WriteLine("You guessed the word!");
                    break;
                }

                Console.WriteLine("Guess a letter:");
                letter = char.ToLower(char.Parse(Console.ReadLine()));

                if (hangman.ContainsLetter(letter))
                {
                    if (hangman.LetterUsedAlready(letter)) {
                        Console.WriteLine("You already used this letter! Try another one.");
                    }
                    else {
                        Console.WriteLine("You guessed a letter!");
                        hangman.AddLetter(letter);
                        Console.WriteLine(hangman.ToString());
                    }   
                }

                else
                {
                    hangman.ReduceLives();
                    Console.WriteLine("You guessed a wrong letter!");
                    Console.WriteLine($"You have {hangman.Lives} lives left!");
                }


            } while (hangman.Lives > 0);

        }
    }
}
