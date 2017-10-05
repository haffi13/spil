using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    public class TicTacToe
    {
        public int numberOfPlays = 0;
        int bricksOnBoard = 0;
        public char currentPlayer = ' ';
        public char[,] GameBoard { get; set; }
        public int gameMode; // 1 = 3bricks and move , 2 = endless bricks
        TicTacToeMenu tttm = new TicTacToeMenu();

        public TicTacToe() 
        {
            GameBoard = new char[3, 3] { {' ',' ',' '},
                                         {' ',' ',' '}, 
                                         {' ',' ',' '} };
        }

        public string GetGameBoardView()
        {
            string resultat = "";
            resultat = resultat + "GameMode: " + gameMode + "\n";
            resultat = resultat + "Y\n";
            resultat = resultat + "  *******************\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "3 *  " + GameBoard[0, 2] + "  *  " + GameBoard[1, 2] + "  *  " + GameBoard[2, 2] + "  *\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "  *******************\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "2 *  " + GameBoard[0, 1] + "  *  " + GameBoard[1, 1] + "  *  " + GameBoard[2, 1] + "  *\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "  *******************\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "1 *  " + GameBoard[0, 0] + "  *  " + GameBoard[1, 0] + "  *  " + GameBoard[2, 0] + "  *\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "  *******************\n";
            resultat = resultat + "     1     2     3    X\n";

            return resultat;
        }

        public char Player()   //is called after every move
        {
            if (numberOfPlays % 2 == 0)
            {
                currentPlayer = 'X';
            }
            else
            {
                currentPlayer = 'O';
            }
            return currentPlayer;
        }

        public void Validate()
        {
            int j = 0;
            int i = 0;

            for (i = 0; i < 3; i++)
            {       
                if (GameBoard[i, j] == currentPlayer && GameBoard[i, j + 1] == currentPlayer && GameBoard[i, j + 2] == currentPlayer)
                {
                    exitMethod("\n----Player " + currentPlayer + " Won!----");
                }
            }
            for (j = 0, i = 0; j < 3; j++)
            {   
                if (GameBoard[i, j] == currentPlayer && GameBoard[i + 1, j] == currentPlayer && GameBoard[i + 2, j] == currentPlayer)
                {
                    exitMethod("\n----Player " + currentPlayer + " Won!----");
                }
            }
            i = 0;
            j = 0;
            if (GameBoard[i, j + 2] == currentPlayer && GameBoard[i + 1, j + 1] == currentPlayer && GameBoard[i + 2, j] == currentPlayer)
            {
                exitMethod("\n----Player " + currentPlayer + " Won!----");
            }
            if ((GameBoard[i + 2, j + 2] == currentPlayer && GameBoard[i + 1, j + 1] == currentPlayer && GameBoard[i, j] == currentPlayer))
            {
                exitMethod("\n----Player " + currentPlayer + " Won!----");
            }
            if(bricksOnBoard >= 9)
            {
                exitMethod("\n---- The game is tie! ---");
            }
        }

        public void exitMethod(string v)
        {
            bricksOnBoard = 0;
            Console.Clear();
            Console.WriteLine(GetGameBoardView());
            Console.WriteLine(v);
            Console.WriteLine("\nDo you wanna play again\nPress 1 for Yes and 2 for No");
            string n = Console.ReadLine();
            if (n == "1")
            {
                for (int i = 0; i < 3; i++)
                {
                    GameBoard[0, i] = ' ';
                    GameBoard[1, i] = ' ';
                    GameBoard[2, i] = ' ';
                }
                tttm.DoActionFor1();
                tttm.Show();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        public void GetPlacement()
        {   
            if(gameMode == 1)
            {
                if (bricksOnBoard >= 6)     //Checks if there are bricks available in gamemode 1
                {
                    Console.WriteLine("You are out of briks");
                    Console.ReadKey();
                }
                else
                {
                    PlaceBrik();
                }
            }
            else
            {
                PlaceBrik();
            }
        }

        public void PlaceBrik() //lets you place a brick in a empty space
        {
            while (true)
            {
                int[] xyValues = getXY();
                Player();
                if (GameBoard[xyValues[0], xyValues[1]] == ' ')
                {
                    GameBoard[xyValues[0], xyValues[1]] = currentPlayer;
                    break;
                }
                else
                {
                    Console.WriteLine("Selection is not valid");
                }
            }
            bricksOnBoard++;
            Validate();
            numberOfPlays++;        
            Player();      //calls player() to update currentPlayer
        }

        public void ChangePlacement()
        {
            if (gameMode == 1)   
            {
                if (bricksOnBoard >= 6) //doesn't let you move a brick unless both players have placed 3
                {
                    while (true)
                    {
                        Console.WriteLine("Select brik to move!");
                        int[] xyValues1 = getXY();  //gets input on what brick to move
                        if (GameBoard[xyValues1[0], xyValues1[1]] == currentPlayer) //checks if you select on of your bricks
                        {
                            Console.WriteLine("Select where to move brik!");
                            int[] xyValues2 = getXY();  //gets input on where to move
                            if (GameBoard[xyValues2[0], xyValues2[1]] == ' ') //checks if there is a brick where you want to move
                            {
                                GameBoard[xyValues1[0], xyValues1[1]] = ' ';
                                GameBoard[xyValues2[0], xyValues2[1]] = currentPlayer;
                                Validate();
                                numberOfPlays++;
                                Player();
                                break;
                            }
                            else 
                            {
                                Console.WriteLine("This move is not valid!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Must select one of your bricks");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("First place the rest of your briks");
                    Console.ReadKey();
                }   
            }
            else
            {
                Console.WriteLine("This action is not supported in this game mode...");
                Console.ReadKey();
            }
        }

        public int[] getXY()    //gets x and y values 
        {
            int[] values = new int[2];
            int xVal = 0;
            int yVal = 0;
            while (true)
            {
                Console.Write("Select X: ");
                try
                {
                    xVal = Convert.ToInt32(Console.ReadLine());
                    if (xVal < 1 || xVal > 3)
                    {
                        Console.WriteLine("Selection is not valid");
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Selection is not valid");
                }
            }
            while (true)
            {
                Console.Write("Select Y: ");
                try
                {
                    yVal = Convert.ToInt32(Console.ReadLine());
                    if (yVal < 1 || yVal > 3)
                    {
                        Console.WriteLine("Selection is not valid");
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Selection is not valid");
                }
            }
            values[0] = xVal-1;
            values[1] = yVal-1;
            return values;
        }
    }
}
