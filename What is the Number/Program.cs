using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_is_the_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true){ 
            Random randomMethod = new Random();
            int randomNum = randomMethod.Next(1, 100);
            int resultRandom = randomNum;
            Console.WriteLine(randomNum);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Tervetuloa , Arvaa numero  ( 1 - 100) .");
                Console.ResetColor();
                int userGuess = 0;
            List<int> guesses = new List<int>();
            int numberOfGuesses = 0;
            while (resultRandom != userGuess)
            {
                string inputUser = Console.ReadLine();


                if (!int.TryParse(inputUser, out userGuess))
                {
                 
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Kirjoita oikea numero!!");
                        Console.ResetColor();
                        continue;
                }
                userGuess = Int32.Parse(inputUser);


                     if (userGuess > 100 || userGuess < 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Älä laita suurempi kuin 100 tai pienemi kuin 1!");
                        Console.ResetColor();
                    }
                   else if (userGuess < resultRandom)
                {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Luku on pienempi kuin arvaus!");
                        Console.ResetColor();
                }
                else if (userGuess > resultRandom)
                {

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Luku on suurempi kuin arvaus!");
                        Console.ResetColor();
                    }

                    Console.WriteLine(userGuess);
                guesses.Add(userGuess);
                numberOfGuesses++;


            }


                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Gongratz! Voitit paketti perunoita!");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Sinun Arvaukset oli : " + String.Join(", ", guesses));
            Console.WriteLine("Tarvitsit  :  " + numberOfGuesses + "arvausta");
                Console.ResetColor();

                Console.WriteLine("Haluatko pelata uudelleen?YES/NO");
            string playagain = Console.ReadLine().ToUpper();

            if (playagain == "YES")
            {
                continue;
            }
            else if (playagain == "NO")
            {
                return;
            }
            else
            {
                return;
            }
        }

        }
    }
}
