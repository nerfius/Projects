using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static public Human human = new Human();
        static public AI ai = new AI();

        static private void printValues()
        {
            Console.WriteLine("human: {0}", human.cardValue);
            Console.WriteLine("ai: {0}", ai.cardValue);
        }

        static private void printWinner(int whatPlayer)
        {
            if (whatPlayer == 0) { Console.WriteLine("ai wins!"); }
            else { Console.WriteLine("human wins!"); }
        }

        static private void Game()
        {
            bool roundOver = false;
            bool gameOver = false;
            Random rnd = new Random();
            List<Player> players = new List<Player>();
            players.Add(human);
            players.Add(ai);
            int currentPlayer = 0, otherPlayer = 1;

            while (!gameOver)
            {
                human.cardValue = 0;
                ai.cardValue = 0;
                roundOver = false;

                while (!roundOver)
                {
                    printValues();
                    if (players[currentPlayer].cardValue <= 20)
                    {
                        if (players[currentPlayer].cardValue == 20)
                        {
                            Console.WriteLine("player {0} has 20!", currentPlayer);
                        }
                        else
                        {
                            players[currentPlayer].AddValueToPool();
                        }
                    }
                    if (players[currentPlayer].cardValue > 20)
                    {
                        roundOver = true;
                        printValues();
                        printWinner(currentPlayer);
                        players[otherPlayer].score++;
                        roundOver = true;
                    }
                    {
                        int temp = currentPlayer;
                        currentPlayer = otherPlayer;
                        otherPlayer = temp;
                    }

                    if (human.cardValue == 20 & ai.cardValue == 20)
                    {
                        Console.WriteLine("TIE");
                        printValues();
                        roundOver = true;
                    }
                }
                Console.WriteLine("Score: human-{0} ai-{1}", human.score, ai.score);
                Console.WriteLine("Next round...");
                Console.ReadKey();

                if (human.score == 3 || ai.score == 3) { gameOver = true; }
            }
            Console.WriteLine("Game Over");
        }

        static void Main(string[] args)
        {
            Game();
            Console.ReadKey();
        }
    }
}
