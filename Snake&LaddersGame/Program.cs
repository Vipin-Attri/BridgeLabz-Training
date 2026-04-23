using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Snake_LaddersGame
{
    internal class Program
    {
        static Random random = new Random();

        static int Play(int position)
        {
            int diceRoll = random.Next(1, 7);
            Console.WriteLine($"You rolled the dice and got: {diceRoll}");

            int newPosition = position + diceRoll;

            if (newPosition > 100)
            {
                position = 100 - (newPosition - 100);
            }
            else
            {
                position = newPosition;
            }

            Console.WriteLine($"Your new position is: {position}");
            return position;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Snake and Ladders Game\n*************************************\n");
            int player1Position = 0 , player2Position = 0;
            Console.WriteLine("Player 1 starts at position: " + player1Position);
            Console.WriteLine("Player 2 starts at position: " + player2Position);
            Console.WriteLine("First player to reach position 100 wins the game!\n");
            Console.WriteLine("Press Enter to start the game...");
            Console.ReadLine();
            while (player1Position < 100 && player2Position < 100)
            {
                               Console.WriteLine("Player 1 Turn");
                player1Position = Play(player1Position);
                if (player1Position >= 100)
                {
                    Console.WriteLine("Player 1 Wins!");
                    break;
                }
                Console.WriteLine("Player 2 Turn");
                player2Position = Play(player2Position);
                if (player2Position >= 100)
                {
                    Console.WriteLine("Player 2 Wins!");
                    break;
                }
            }


        }
    }
}
