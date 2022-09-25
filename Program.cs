// Unit 01 Prove: Developer
// Emily Raventos

using System;
using System.Collections.Generic;

namespace prove1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define variables
            int intchoice = -1;
            string player = "X";
            string guessAgain = "yes";
            bool isTie = false;
            bool isWinner = false;
           
            // Create the board
            List<string> board = new List<string> {"1", "2", "3", "4", "5", "6", "7", "8", "9"};

            // Display the board
            DisplayBoard(board);

            // Play the game
            while (isWinner == false && guessAgain == "yes")
            {
                // Ask user to choose a square
                Console.Write($"It's {player}'s turn. Pick a square: ");
                string choice = Console.ReadLine();

                // Convert choice to an int
                int intChoice;
                intChoice = Convert.ToInt32(choice);
                intChoice -= 1;
                
                // If the square isn't taken, 
                if (board[intChoice] != "X" && board[intChoice] != "O")
                {
                    board[intChoice] = player;
                    DisplayBoard(board);
                                    
                    // CheckWin()
                    if (
                        (board[0] == player && board[1] == player && board[2] == player)
                        || (board[3] == player && board[4] == player && board[5] == player)
                        || (board[6] == player && board[7] == player && board[8] == player) 
                        || (board[0] == player && board[3] == player && board[6] == player)
                        || (board[1] == player && board[4] == player && board[7] == player)
                        || (board[2] == player && board[5] == player && board[8] == player)
                        || (board[0] == player && board[4] == player && board[8] == player)
                        || (board[2] == player && board[4] == player && board[6] == player)
                        )
                        {
                            isWinner = true;  
                            Console.WriteLine($"{player} is the winner!"); 
                        }
                                
                    // CheckTie()
                    if (
                        (board[0] == "X" || board[0] == "O")
                        && (board[1] == "X" || board[1] == "O")
                        && (board[2] == "X" || board[2] == "O") 
                        && (board[3] == "X" || board[3] == "O")
                        && (board[4] == "X" || board[4] == "O")
                        && (board[5] == "X" || board[5] == "O")
                        && (board[6] == "X" || board[6] == "O")
                        && (board[7] == "X" || board[7] == "O")
                        && (board[8] == "X" || board[8] == "O")
                        && (isWinner == false)
                        )
                    {
                        isTie = true;
                        Console.WriteLine("It's a tie!");
                        isWinner = true;
                    }
                }

                // If user picks a spot that is already taken, ask if they'd like to pick again
                else
                {
                    Console.WriteLine("That spot is already taken. Want to guess again (yes/no)? ");
                    guessAgain = Console.ReadLine();
                }

                if (guessAgain == "no")
                {
                    Console.WriteLine($"{player} forfeited the game.");
                }

                // SwitchTurn()
                if (player == "X")
                {
                    player = "O";
                }
                else
                {
                    player = "X"; 
                }
            }
        }

        // // Function to check if they tied
        static bool checkTie(List<string> board, bool isTie, bool isWinner)
        {
            if (
                (board[0] == "X" || board[0] == "O")
                && (board[1] == "X" || board[1] == "O")
                && (board[2] == "X" || board[2] == "O") 
                && (board[3] == "X" || board[3] == "O")
                && (board[4] == "X" || board[4] == "O")
                && (board[5] == "X" || board[5] == "O")
                && (board[6] == "X" || board[6] == "O")
                && (board[7] == "X" || board[7] == "O")
                && (board[8] == "X" || board[8] == "O")
                && (isWinner == false)
                )
                {
                    isTie = true;
                    Console.WriteLine("It's a tie!");
                    isWinner = true;
                }
                return isTie;
                return isWinner;
        }

        // Function to check if they won
        static bool checkWin(List<string> board, string player, bool isWinner)
        {
            if (
                (board[0] == player && board[1] == player && board[2] == player)
                || (board[3] == player && board[4] == player && board[5] == player)
                || (board[6] == player && board[7] == player && board[8] == player) 
                || (board[0] == player && board[3] == player && board[6] == player)
                || (board[1] == player && board[4] == player && board[7] == player)
                || (board[2] == player && board[5] == player && board[8] == player)
                || (board[0] == player && board[4] == player && board[8] == player)
                || (board[2] == player && board[4] == player && board[6] == player)
                )
                    isWinner = true;
                    return isWinner;    
                    Console.WriteLine($"{player} is the winner!");   
        }

        // Function to switch turns
        static string switchTurn(string player)
        {
            if (player == "X")
            {
                player = "O";
            }
            else
            {
                player = "X";
            }

            return player;
        }

        // Function to display the board
        static void DisplayBoard(List<string> board)
        {
            Console.WriteLine($"{board[0]} | {board[1]} | {board[2]}");
            Console.WriteLine("- + - + -");
            Console.WriteLine($"{board[3]} | {board[4]} | {board[5]}");
            Console.WriteLine("- + - + -");
            Console.WriteLine($"{board[6]} | {board[7]} | {board[8]}");
        }
    }

}