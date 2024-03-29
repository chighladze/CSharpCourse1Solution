﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP.HomeWorks
{

    public enum GuessingPlayer
    {
        Human,
        Machine
    }
    public class GuessNumberGame
    {
        private readonly int max;
        private readonly int maxTries;
        private readonly GuessingPlayer guessingPlayer;

        public GuessNumberGame(int max = 100, int maxTries = 5, GuessingPlayer guessingPlayer = GuessingPlayer.Human)
        {
            this.max = max;
            this.maxTries = maxTries;
            this.guessingPlayer = guessingPlayer;

        }

        public void Start()
        {
            if (guessingPlayer == GuessingPlayer.Human)
            {
                HumanGuesses();
            } 
            else
            {
                MachineGuesses();
            }
        }

        private void HumanGuesses()
        {
            Random rand = new Random();
            int gussedNumber = rand.Next(0, max);

            int lastGuess = -1;
            int tries = 0;
            while (lastGuess != gussedNumber && tries < maxTries)
            {
                Console.WriteLine("Guess the number!");
                lastGuess = int.Parse(Console.ReadLine());

                if (lastGuess == gussedNumber)
                {
                    Console.WriteLine("Congrats! You guessed the number!");
                    break;
                }
                else if(lastGuess < gussedNumber)
                {
                    Console.WriteLine("My number is greater!");
                }
                else
                {
                    Console.WriteLine("My number is less!");
                }

                tries++;

                if (tries == maxTries)
                {
                    Console.WriteLine("You lost!");
                }
            }


        }

        private void MachineGuesses()
        {
            Console.WriteLine("Enter a number that's going to be guessed by a computer.");

            int gussedNumber = -1;
            while (gussedNumber == -1)
            {
                int parsedNumber = int.Parse(Console.ReadLine());
                if (parsedNumber >= 0 && parsedNumber <= this.max)
                {
                    gussedNumber = parsedNumber;
                }

                int lastGuess = -1;
                int min = 0;
                int max = this.max;
                int tries = 0;

                while (lastGuess != gussedNumber && tries < maxTries)
                {
                    lastGuess = (max + min) / 2;
                    Console.WriteLine($"Did you guess this number - {lastGuess}?");
                    Console.WriteLine($"If yes, enter 'y', if you number is greater - enter 'g', if less - 'l'");

                    string answer = Console.ReadLine();
                    if (answer == "y")
                    {
                        Console.WriteLine("Supper! I guessed your number, man!");
                        break;
                    }
                    else if (answer == "g")
                    {
                        min = lastGuess;
                    }
                    else
                    {
                        max = lastGuess;
                    }
                    if (lastGuess == gussedNumber)
                    {
                        Console.WriteLine("Don't cheat, man!");
                    }
                    tries++;
                    if (tries == maxTries)
                    {
                        Console.WriteLine("No tries anymore :( I lost! ");
                    }
                }
            }
        }

    }
}
