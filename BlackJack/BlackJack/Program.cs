﻿using System;
using Casino;
using Casino.BlackJack;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";
            Guid identifier = Guid.NewGuid();

            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();
            Console.WriteLine("And How much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "ya" || answer == "yea") 
            { 
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.IsActivelyPlaying = true;
                while (player.IsActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing.");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();
        }
    }
}
