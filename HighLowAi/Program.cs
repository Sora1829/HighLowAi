using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowAi
{
    class Program
    {
        public static int UserEntry;
        static void Main(string[] args)
        {
            AskToStart();
        }

        public static void AskToStart()
        {
            Console.WriteLine("Please enter a number from 0-10000 for the Albert the AI to guess");
            UserEntry = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Albert.Guess();
        }
    }
}
