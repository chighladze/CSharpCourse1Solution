using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace D_OOP.Homeworks
{
    public class GuessTheNumber
    {
        public void StartGame()
        {
            Console.WriteLine("<< To start the game, guess a number from 0 to 100 >>");
            Console.Write("Please enter a number: ");
            int guessNum = int.Parse(Console.ReadLine());

            int attempts = 5;
            int guessingAttempt = GuessNum(attempts);
            while (attempts > 0)
            {
                if (guessNum == guessingAttempt)
                {
                    Console.WriteLine("<< Congratulations, you guessed the number! >>");
                    break;
                }
                else
                {

                    attempts = attempts - 1;
                    if (attempts == 0)
                    {
                        Console.WriteLine("<< You lost, you have no attempts left! >>");
                        break;
                    }
                    if (guessNum > guessingAttempt)
                    {
                        Console.WriteLine("<< the hidden number is greater than yours  >>");
                    }
                    if (guessNum < guessingAttempt)
                    {
                        Console.WriteLine("<< the hidden number is less than yours  >>");
                    }

                    guessingAttempt = GuessNum(attempts);
                }
            }
        }

        public int GuessNum(int attempts)
        {
            Console.WriteLine($"You have {attempts} tries to guess the number");
            Console.Write("Please enter a number: ");
            int num = int.Parse(Console.ReadLine());

            return num;
        }




    }
}