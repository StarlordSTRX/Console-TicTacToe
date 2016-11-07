using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeConsole
{
    class Program
    {

        private static List<string> gridMarkers = new List<string>();
        
        static void Main(string[] args)
        {
            
            bool playerOneTurn = true;

            //make 0 blank for easier counting controls
            gridMarkers.Add("-");

            //itterate to fill out the rest of the list
            for (int i = 0; i < 9; i++)
            {
                gridMarkers.Add(" ");
            }

            Console.WriteLine("Welcome to Console TicTacToe!\n");

            drawBoard(gridMarkers);
            
            //While nobody has won yet
            while (winCondition() == "" )
            {    //player one
                if (playerOneTurn == true)
                {
                    playerMove(true);
                    playerOneTurn = false;
                }
                //player two
                else
                {
                    playerMove(false);
                    playerOneTurn = true;
                }
                drawBoard(gridMarkers);
                Console.WriteLine(winCondition());
            }
           
            Console.WriteLine("That's it! Thanks for playing!\nPress any key to exit...");
            Console.ReadKey();
     }

            //functions
            public static void drawBoard(List<string> markers){
                gridMarkers = markers;
                Console.WriteLine(" | 1 | 2 | 3 | \n |---|---|---| ");
                //A Row
                Console.WriteLine("A| {0} | {1} | {2} |", markers[1], markers[2], markers[3]);
                Console.WriteLine(" |---|---|---|");
                //B Row
                Console.WriteLine("B| {0} | {1} | {2} |", markers[4],markers[5],markers[6]);
                Console.WriteLine(" |---|---|---|");
                //C Row
                Console.WriteLine("C| {0} | {1} | {2} |", markers[7], markers[8], markers[9]);
                Console.WriteLine(" |---|---|---|");
            }

            //Let a player make a move
            public static void playerMove(bool playerOne)
            {
                string currentPlayer;
                bool correctPlacement = false;
                //Define current player as either X or O
                if (playerOne){ currentPlayer = "X"; } else { currentPlayer = "O"; }
                    Console.Write("Player {0}! make a move: ",currentPlayer);
                        //make sure the user doesn't fuck up
                        while (correctPlacement == false) { 
                            string playerInput = Console.ReadLine();
                            switch (playerInput.ToLower()) {
                                case "a1":
                                    if (gridMarkers[1] == " ") { gridMarkers[1] = currentPlayer; correctPlacement = true; } else { Console.Write("Square already contains a marker, try again: "); break; }
                                    break;
                                case "a2":
                                    if (gridMarkers[2] == " ") { gridMarkers[2] = currentPlayer; correctPlacement = true; } else { Console.Write("Square already contains a marker, try again: "); break; }
                                    break;
                                case "a3":
                                    if (gridMarkers[3] == " ") { gridMarkers[3] = currentPlayer; correctPlacement = true; } else { Console.Write("Square already contains a marker, try again: "); break; }
                                    break;
                                case "b1":
                                    if (gridMarkers[4] == " ") { gridMarkers[4] = currentPlayer; correctPlacement = true; } else { Console.Write("Square already contains a marker, try again: "); break; }
                                    break;
                                case "b2":
                                    if (gridMarkers[5] == " ") { gridMarkers[5] = currentPlayer; correctPlacement = true; } else { Console.Write("Square already contains a marker, try again: "); break; }
                                    break;
                                case "b3":
                                    if (gridMarkers[6] == " ") { gridMarkers[6] = currentPlayer; correctPlacement = true; } else { Console.Write("Square already contains a marker, try again: "); break; }
                                    break;
                                case "c1":
                                    if (gridMarkers[7] == " ") { gridMarkers[7] = currentPlayer; correctPlacement = true; } else { Console.Write("Square already contains a marker, try again: "); break; }
                                    break;
                                case "c2":
                                    if (gridMarkers[8] == " ") { gridMarkers[8] = currentPlayer; correctPlacement = true; } else { Console.Write("Square already contains a marker, try again: "); break; }
                                    break;
                                case "c3":
                                    if (gridMarkers[9] == " ") { gridMarkers[9] = currentPlayer; correctPlacement = true; } else { Console.Write("Square already contains a marker, try again: "); break; }
                                    break;
                                default:
                                    Console.Write("unknown value! Try Again: ");
                                    break;
                        }
                    }
                
            }


            public static string winCondition()
            {
                //vertical
                if (gridMarkers[1] == gridMarkers[2] && gridMarkers[2] == gridMarkers[3] && gridMarkers[1] != " ") { return gridMarkers[1] + " Wins!"; }
                else if (gridMarkers[4] == gridMarkers[5] && gridMarkers[5] == gridMarkers[6] && gridMarkers[4] != " ") { return gridMarkers[4] + " Wins!"; }
                else if (gridMarkers[7] == gridMarkers[8] && gridMarkers[8] == gridMarkers[9] && gridMarkers[7] != " ") { return gridMarkers[7] + " Wins!"; }
                //horizontal
                else if (gridMarkers[1] == gridMarkers[4] && gridMarkers[4] == gridMarkers[7] && gridMarkers[4] != " ") { return gridMarkers[4] + " Wins!"; }
                else if (gridMarkers[2] == gridMarkers[5] && gridMarkers[5] == gridMarkers[8] && gridMarkers[2] != " ") { return gridMarkers[4] + " Wins!"; }
                else if (gridMarkers[3] == gridMarkers[6] && gridMarkers[6] == gridMarkers[9] && gridMarkers[3] != " ") { return gridMarkers[4] + " Wins!"; }
                //diagonal
                else if (gridMarkers[1] == gridMarkers[5] &&  gridMarkers[5] == gridMarkers[9] && gridMarkers[1] != " ") { return gridMarkers[1] + " Wins!"; }
                else if (gridMarkers[3] == gridMarkers[5] && gridMarkers[5] == gridMarkers[7] && gridMarkers[3] != " ") { return gridMarkers[3] + " Wins!"; }
                //It's a tie!
                else if(gridMarkers[1] != " " && gridMarkers[2] != " " && gridMarkers[3] != " " && gridMarkers[4] != " " && gridMarkers[5] != " " && gridMarkers[6] != " " && gridMarkers[7] != " " && gridMarkers[8] != " " && gridMarkers[9] != " ")
                { return "It's a tie!"; }
                //no win detected
                else { return ""; }
            }
    }
}
