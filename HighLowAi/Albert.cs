using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowAi
{
    class Albert
    {
        public static void Guess()
        {
            Random rand = new Random();
            string read;
            int Highest = 10001;
            int Lowest = 0;
            int LastGuess = 0;
            List<int> Guessed = new List<int>();

            while (LastGuess != Program.UserEntry)
            {
                LastGuess = rand.Next(Lowest, Highest);

                if (LastGuess > Program.UserEntry)
                {
                    Highest = LastGuess;
                    Guessed.Add(LastGuess);
                }
                else if (LastGuess < Program.UserEntry)
                {
                    Lowest = LastGuess + 1;
                    Guessed.Add(LastGuess);
                }
            }

            Console.WriteLine("Albert Guessed it in " + Guessed.Count());

            Console.WriteLine(" Would You like to see his guesses Y/N");
            read = Console.ReadLine();

            if (read.Contains("y") || read.Contains("Y"))
            {
                for (int i = 0; i < Guessed.Count(); i++)
                {
                    Console.WriteLine(Guessed[i]);
                }
            }

            Console.WriteLine("Would you like to play again Y/N");
            read = Console.ReadLine();

            if (read.Contains("y") || read.Contains("Y"))
            {
                Console.Clear();
                Program.AskToStart();
            }
        }
    }
}
