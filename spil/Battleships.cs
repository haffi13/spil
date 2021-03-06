﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil                                  
{
    public class Battleships //was just class, changed to public for testing purposes
    {
        public char[,] player1ships { get; set; }
        public char[,] player1shots { get; set; }

        public char[,] player2ships { get; set; }
        public char[,] player2shots { get; set; }
        public int numberOfPlays = 0;
        int player1hits = 0;
        int player2hits = 0;
        int player1ShipsLeft = 9;
        int player2ShipsLeft = 9;
        public int gameVariation;
        bool p1LosesTurn = false;
        bool p2LosesTurn = false;

        public Battleships()
        {
             player1ships = new char[10, 10]
            {
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '}
            };
            

            player2ships = new char[10, 10]
           {
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '}
           };

            player1shots = new char[10, 10]
          {
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '}
          };
            player2shots = new char[10, 10]
          {
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '}
          };

        }
        public string GetGameBoardViewLayDown(char[,] curr)
        {
            string boardLayout = string.Empty;
            string starline = "   *************************************************************\n";
            string btwnLine = "   *     *     *     *     *     *     *     *     *     *     *\n";
            string bsb = btwnLine + starline + btwnLine;

            boardLayout += CurrentPlayer();
            boardLayout += starline + btwnLine;
            boardLayout += "10 *  " + curr[0, 9] + "  *  " + curr[1, 9] + "  *  " + curr[2, 9] + "  *  " + curr[3, 9] + "  *  " + curr[4, 9] + "  *  " + curr[5, 9] + "  *  " + curr[6, 9] + "  *  " + curr[7, 9] + "  *  " + curr[8, 9] + "  *  " + curr[9, 9] + "  *\n";
            boardLayout += bsb;
            boardLayout += " 9 *  " + curr[0, 8] + "  *  " + curr[1, 8] + "  *  " + curr[2, 8] + "  *  " + curr[3, 8] + "  *  " + curr[4, 8] + "  *  " + curr[5, 8] + "  *  " + curr[6, 8] + "  *  " + curr[7, 8] + "  *  " + curr[8, 8] + "  *  " + curr[9, 8] + "  *\n";
            boardLayout += bsb;
            boardLayout += " 8 *  " + curr[0, 7] + "  *  " + curr[1, 7] + "  *  " + curr[2, 7] + "  *  " + curr[3, 7] + "  *  " + curr[4, 7] + "  *  " + curr[5, 7] + "  *  " + curr[6, 7] + "  *  " + curr[7, 7] + "  *  " + curr[8, 7] + "  *  " + curr[9, 7] + "  *\n";
            boardLayout += bsb;
            boardLayout += " 7 *  " + curr[0, 6] + "  *  " + curr[1, 6] + "  *  " + curr[2, 6] + "  *  " + curr[3, 6] + "  *  " + curr[4, 6] + "  *  " + curr[5, 6] + "  *  " + curr[6, 6] + "  *  " + curr[7, 6] + "  *  " + curr[8, 6] + "  *  " + curr[9, 6] + "  *\n";
            boardLayout += bsb;
            boardLayout += " 6 *  " + curr[0, 5] + "  *  " + curr[1, 5] + "  *  " + curr[2, 5] + "  *  " + curr[3, 5] + "  *  " + curr[4, 5] + "  *  " + curr[5, 5] + "  *  " + curr[6, 5] + "  *  " + curr[7, 5] + "  *  " + curr[8, 5] + "  *  " + curr[9, 5] + "  *\n";
            boardLayout += bsb;
            boardLayout += " 5 *  " + curr[0, 4] + "  *  " + curr[1, 4] + "  *  " + curr[2, 4] + "  *  " + curr[3, 4] + "  *  " + curr[4, 4] + "  *  " + curr[5, 4] + "  *  " + curr[6, 4] + "  *  " + curr[7, 4] + "  *  " + curr[8, 4] + "  *  " + curr[9, 4] + "  *\n";
            boardLayout += bsb;
            boardLayout += " 4 *  " + curr[0, 3] + "  *  " + curr[1, 3] + "  *  " + curr[2, 3] + "  *  " + curr[3, 3] + "  *  " + curr[4, 3] + "  *  " + curr[5, 3] + "  *  " + curr[6, 3] + "  *  " + curr[7, 3] + "  *  " + curr[8, 3] + "  *  " + curr[9, 3] + "  *\n";
            boardLayout += bsb;
            boardLayout += " 3 *  " + curr[0, 2] + "  *  " + curr[1, 2] + "  *  " + curr[2, 2] + "  *  " + curr[3, 2] + "  *  " + curr[4, 2] + "  *  " + curr[5, 2] + "  *  " + curr[6, 2] + "  *  " + curr[7, 2] + "  *  " + curr[8, 2] + "  *  " + curr[9, 2] + "  *\n";
            boardLayout += bsb;
            boardLayout += " 2 *  " + curr[0, 1] + "  *  " + curr[1, 1] + "  *  " + curr[2, 1] + "  *  " + curr[3, 1] + "  *  " + curr[4, 1] + "  *  " + curr[5, 1] + "  *  " + curr[6, 1] + "  *  " + curr[7, 1] + "  *  " + curr[8, 1] + "  *  " + curr[9, 1] + "  *\n";
            boardLayout += bsb;
            boardLayout += " 1 *  " + curr[0, 0] + "  *  " + curr[1, 0] + "  *  " + curr[2, 0] + "  *  " + curr[3, 0] + "  *  " + curr[4, 0] + "  *  " + curr[5, 0] + "  *  " + curr[6, 0] + "  *  " + curr[7, 0] + "  *  " + curr[8, 0] + "  *  " + curr[9, 0] + "  *\n";
            boardLayout += btwnLine + starline;
            boardLayout += "      A     B     C     D     E     F     G     H     I     J";
            return boardLayout;
        }

        public string GetGameBoardViewPlay(char[,] board1, char[,] board2)
        {
            string boardLayout = string.Empty;
            string starline = "   *************************************************************" + "   " + "   *************************************************************\n";
            string btwnLine = "   *     *     *     *     *     *     *     *     *     *     *" + "   " + "   *     *     *     *     *     *     *     *     *     *     *\n";
            string bsb = btwnLine + starline + btwnLine;
            boardLayout += CurrentPlayer();
            boardLayout += starline + btwnLine;
            boardLayout += "10 *  " + board1[0, 9] + "  *  " + board1[1, 9] + "  *  " + board1[2, 9] + "  *  " + board1[3, 9] + "  *  " + board1[4, 9] + "  *  " + board1[5, 9] + "  *  " + board1[6, 9] + "  *  " + board1[7, 9] + "  *  " + board1[8, 9] + "  *  " + board1[9, 9] + "  *" + "   " + "10 *  " + board2[0, 9] + "  *  " + board2[1, 9] + "  *  " + board2[2, 9] + "  *  " + board2[3, 9] + "  *  " + board2[4, 9] + "  *  " + board2[5, 9] + "  *  " + board2[6, 9] + "  *  " + board2[7, 9] + "  *  " + board2[8, 9] + "  *  " + board2[9, 9] + "  *\n";
            boardLayout += bsb;
            boardLayout += " 9 *  " + board1[0, 8] + "  *  " + board1[1, 8] + "  *  " + board1[2, 8] + "  *  " + board1[3, 8] + "  *  " + board1[4, 8] + "  *  " + board1[5, 8] + "  *  " + board1[6, 8] + "  *  " + board1[7, 8] + "  *  " + board1[8, 8] + "  *  " + board1[9, 8] + "  *" + "   " + " 9 *  " + board2[0, 8] + "  *  " + board2[1, 8] + "  *  " + board2[2, 8] + "  *  " + board2[3, 8] + "  *  " + board2[4, 8] + "  *  " + board2[5, 8] + "  *  " + board2[6, 8] + "  *  " + board2[7, 8] + "  *  " + board2[8, 8] + "  *  " + board2[9, 8] + "  *\n";
            boardLayout += bsb;
            boardLayout += " 8 *  " + board1[0, 7] + "  *  " + board1[1, 7] + "  *  " + board1[2, 7] + "  *  " + board1[3, 7] + "  *  " + board1[4, 7] + "  *  " + board1[5, 7] + "  *  " + board1[6, 7] + "  *  " + board1[7, 7] + "  *  " + board1[8, 7] + "  *  " + board1[9, 7] + "  *" + "   " + " 8 *  " + board2[0, 7] + "  *  " + board2[1, 7] + "  *  " + board2[2, 7] + "  *  " + board2[3, 7] + "  *  " + board2[4, 7] + "  *  " + board2[5, 7] + "  *  " + board2[6, 7] + "  *  " + board2[7, 7] + "  *  " + board2[8, 7] + "  *  " + board2[9, 7] + "  *\n";
            boardLayout += bsb;
            boardLayout += " 7 *  " + board1[0, 6] + "  *  " + board1[1, 6] + "  *  " + board1[2, 6] + "  *  " + board1[3, 6] + "  *  " + board1[4, 6] + "  *  " + board1[5, 6] + "  *  " + board1[6, 6] + "  *  " + board1[7, 6] + "  *  " + board1[8, 6] + "  *  " + board1[9, 6] + "  *" + "   " + " 7 *  " + board2[0, 6] + "  *  " + board2[1, 6] + "  *  " + board2[2, 6] + "  *  " + board2[3, 6] + "  *  " + board2[4, 6] + "  *  " + board2[5, 6] + "  *  " + board2[6, 6] + "  *  " + board2[7, 6] + "  *  " + board2[8, 6] + "  *  " + board2[9, 6] + "  *\n";
            boardLayout += bsb;
            boardLayout += " 6 *  " + board1[0, 5] + "  *  " + board1[1, 5] + "  *  " + board1[2, 5] + "  *  " + board1[3, 5] + "  *  " + board1[4, 5] + "  *  " + board1[5, 5] + "  *  " + board1[6, 5] + "  *  " + board1[7, 5] + "  *  " + board1[8, 5] + "  *  " + board1[9, 5] + "  *" + "   " + " 6 *  " + board2[0, 5] + "  *  " + board2[1, 5] + "  *  " + board2[2, 5] + "  *  " + board2[3, 5] + "  *  " + board2[4, 5] + "  *  " + board2[5, 5] + "  *  " + board2[6, 5] + "  *  " + board2[7, 5] + "  *  " + board2[8, 5] + "  *  " + board2[9, 5] + "  *\n";
            boardLayout += bsb;
            boardLayout += " 5 *  " + board1[0, 4] + "  *  " + board1[1, 4] + "  *  " + board1[2, 4] + "  *  " + board1[3, 4] + "  *  " + board1[4, 4] + "  *  " + board1[5, 4] + "  *  " + board1[6, 4] + "  *  " + board1[7, 4] + "  *  " + board1[8, 4] + "  *  " + board1[9, 4] + "  *" + "   " + " 5 *  " + board2[0, 4] + "  *  " + board2[1, 4] + "  *  " + board2[2, 4] + "  *  " + board2[3, 4] + "  *  " + board2[4, 4] + "  *  " + board2[5, 4] + "  *  " + board2[6, 4] + "  *  " + board2[7, 4] + "  *  " + board2[8, 4] + "  *  " + board2[9, 4] + "  *\n";
            boardLayout += bsb;
            boardLayout += " 4 *  " + board1[0, 3] + "  *  " + board1[1, 3] + "  *  " + board1[2, 3] + "  *  " + board1[3, 3] + "  *  " + board1[4, 3] + "  *  " + board1[5, 3] + "  *  " + board1[6, 3] + "  *  " + board1[7, 3] + "  *  " + board1[8, 3] + "  *  " + board1[9, 3] + "  *" + "   " + " 4 *  " + board2[0, 3] + "  *  " + board2[1, 3] + "  *  " + board2[2, 3] + "  *  " + board2[3, 3] + "  *  " + board2[4, 3] + "  *  " + board2[5, 3] + "  *  " + board2[6, 3] + "  *  " + board2[7, 3] + "  *  " + board2[8, 3] + "  *  " + board2[9, 3] + "  *\n";
            boardLayout += bsb;
            boardLayout += " 3 *  " + board1[0, 2] + "  *  " + board1[1, 2] + "  *  " + board1[2, 2] + "  *  " + board1[3, 2] + "  *  " + board1[4, 2] + "  *  " + board1[5, 2] + "  *  " + board1[6, 2] + "  *  " + board1[7, 2] + "  *  " + board1[8, 2] + "  *  " + board1[9, 2] + "  *" + "   " + " 3 *  " + board2[0, 2] + "  *  " + board2[1, 2] + "  *  " + board2[2, 2] + "  *  " + board2[3, 2] + "  *  " + board2[4, 2] + "  *  " + board2[5, 2] + "  *  " + board2[6, 2] + "  *  " + board2[7, 2] + "  *  " + board2[8, 2] + "  *  " + board2[9, 2] + "  *\n";
            boardLayout += bsb;
            boardLayout += " 2 *  " + board1[0, 1] + "  *  " + board1[1, 1] + "  *  " + board1[2, 1] + "  *  " + board1[3, 1] + "  *  " + board1[4, 1] + "  *  " + board1[5, 1] + "  *  " + board1[6, 1] + "  *  " + board1[7, 1] + "  *  " + board1[8, 1] + "  *  " + board1[9, 1] + "  *" + "   " + " 2 *  " + board2[0, 1] + "  *  " + board2[1, 1] + "  *  " + board2[2, 1] + "  *  " + board2[3, 1] + "  *  " + board2[4, 1] + "  *  " + board2[5, 1] + "  *  " + board2[6, 1] + "  *  " + board2[7, 1] + "  *  " + board2[8, 1] + "  *  " + board2[9, 1] + "  *\n";
            boardLayout += bsb;
            boardLayout += " 1 *  " + board1[0, 0] + "  *  " + board1[1, 0] + "  *  " + board1[2, 0] + "  *  " + board1[3, 0] + "  *  " + board1[4, 0] + "  *  " + board1[5, 0] + "  *  " + board1[6, 0] + "  *  " + board1[7, 0] + "  *  " + board1[8, 0] + "  *  " + board1[9, 0] + "  *" + "   " + " 1 *  " + board2[0, 0] + "  *  " + board2[1, 0] + "  *  " + board2[2, 0] + "  *  " + board2[3, 0] + "  *  " + board2[4, 0] + "  *  " + board2[5, 0] + "  *  " + board2[6, 0] + "  *  " + board2[7, 0] + "  *  " + board2[8, 0] + "  *  " + board2[9, 0] + "  *\n";
            boardLayout += btwnLine + starline;
            boardLayout += "      A     B     C     D     E     F     G     H     I     J   " + "   " + "      A     B     C     D     E     F     G     H     I     J   ";
            return boardLayout;
        }

        public char[,] CurrentPlayerBoard()
        {
            if(numberOfPlays % 2 == 0)
            {//player1
                return player1ships;
            }
            else
            {//player2
                return player2ships;
            }
        }
        
        public void ValidateWinner(int p1, int p2) 
        {
            if(p1 == 28 || p2 == 28)
            {
                Console.Clear();
                if(p1 == 28)
                {
                    Console.WriteLine("Player 1 WON!");
                }
                else
                {
                    Console.WriteLine("Player 1 WON!");
                }
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        player1ships[i, j] = ' ';
                        player1shots[i, j] = ' ';
                        player2ships[i, j] = ' ';
                        player2shots[i, j] = ' ';
                    }
                }
                player1hits = 0;
                player2hits = 0;
                player1ShipsLeft = 9;
                player2ShipsLeft = 9;
                numberOfPlays = 0;
                Console.ReadKey();

            }
            else
            {
                PlaceShot();
            }
        }

        public string CurrentPlayer()
        {
            string ret = string.Empty;
            if(numberOfPlays % 2 == 0)
            {
                ret = "   ---   Player 1   ---   \n";
            }
            else
            {
                ret = "   ---   Player 2   ---   \n";
            }
            return ret;
        }

        public void PlaceShot()
        {
            Console.Clear();
            Console.WriteLine(CurrentPlayer());
            Console.ReadKey();
            Console.Clear();
 
            if(numberOfPlays % 2 == 0)
            {//player 1 is doing, shoot at player 2
                Console.WriteLine(GetGameBoardViewPlay(player1ships, player1shots));
                int[] shotXY = getXY();

                if(player2ships[shotXY[0],shotXY[1]] != ' ' && player2ships[shotXY[0], shotXY[1]] != 'X' && player2ships[shotXY[0], shotXY[1]] != 'O')
                {//ship hit
                    char shipLetter = player2ships[shotXY[0], shotXY[1]];
                       //to show where u shoot on opponents board
                    if(player2ships[shotXY[0],shotXY[1]] != 'm')
                    {
                        player1hits++;
                        player1shots[shotXY[0], shotXY[1]] = 'X';
                        player2ships[shotXY[0], shotXY[1]] = 'X';
                        Console.WriteLine(GetGameBoardViewPlay(player1ships, player1shots));
                        Console.WriteLine("RAMT!");
                        SinkCheck(shotXY[0], shotXY[1], 1, shipLetter);
                        p1LosesTurn = false;
                    }
                    else
                    {
                        player1shots[shotXY[0], shotXY[1]] = 'X';
                        player2ships[shotXY[0], shotXY[1]] = 'X';
                        Console.WriteLine(GetGameBoardViewPlay(player1ships, player1shots));
                        Console.WriteLine("BAM! \nYou hit a mine, you lose a turn!");
                        p1LosesTurn = true;
                    }

                }
                else
                {//not hit
                    player1shots[shotXY[0], shotXY[1]] = 'O';
                    Console.WriteLine(GetGameBoardViewPlay(player1ships, player1shots));
                    Console.WriteLine("PLASK");
                }
                if (p2LosesTurn == false) numberOfPlays++;
                else
                {
                    p2LosesTurn = false;
                    numberOfPlays += 2;
                }
                Console.ReadKey();
                Console.Clear();
            }

            else
            {
                Console.WriteLine(GetGameBoardViewPlay(player2ships, player2shots));
                int[] shotXY = getXY();

                if (player1ships[shotXY[0], shotXY[1]] != ' ' && player1ships[shotXY[0], shotXY[1]] != 'X' && player1ships[shotXY[0], shotXY[1]] != 'O')
                {//ship hit
                    char shipLetter = player1ships[shotXY[0], shotXY[1]];
                    
                    if(player1ships[shotXY[0],shotXY[1]] != 'm')
                    {
                        player2hits++;
                        player2shots[shotXY[0], shotXY[1]] = 'X';
                        player1ships[shotXY[0], shotXY[1]] = 'X';
                        Console.WriteLine(GetGameBoardViewPlay(player2ships, player2shots));
                        Console.WriteLine("RAMT!");
                        SinkCheck(shotXY[0], shotXY[1], 2, shipLetter);
                        p2LosesTurn = false;
                    }
                    else
                    {
                        player2shots[shotXY[0], shotXY[1]] = 'X';
                        player1ships[shotXY[0], shotXY[1]] = 'X';
                        Console.WriteLine(GetGameBoardViewPlay(player2ships, player2shots));
                        Console.WriteLine("BAM! \nYou hit a mine, you lose a turn!");
                        p2LosesTurn = true;
                    }
                }
                else
                {//not hit
                    player2shots[shotXY[0], shotXY[1]] = 'O';
                    Console.WriteLine(GetGameBoardViewPlay(player2ships, player2shots));
                    Console.WriteLine("PLASK");
                }
                if (p1LosesTurn == false) numberOfPlays++;
                else
                {
                    p1LosesTurn = false;
                    numberOfPlays += 2;
                }
                Console.ReadKey();
                Console.Clear();
            }
            ValidateWinner(player1hits, player2hits);
        }

        public void SinkCheck(int x, int y, int player, char ship)
        {
            bool shipSunk = true;
            if(player == 1)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if(player2ships[i,j] == ship)
                        {//not sunk
                            shipSunk = false;
                        }
                    }
                }
                if (shipSunk == true)
                {
                    player2ShipsLeft--;
                    MakeMsg(player);
                }
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (player1ships[i, j] == ship)
                        {//not sunk
                            shipSunk = false;
                        }
                    }
                }
                if (shipSunk == true)
                {
                    player1ShipsLeft--;
                    MakeMsg(player);
                }
            }
        }

        public void PlaceShips()
        //9 total ships per player
        {
            Console.WriteLine(GetGameBoardViewLayDown(CurrentPlayerBoard()));
            string id;
            Skib Hangar = new Skib();
            Hangar.amount = 1;
            Hangar.length = 5;
            Hangar.name = "Hangar";
            for (int i = 0; i < Hangar.amount; i++)
            {
                Console.WriteLine(ShipPlacingMessage(Hangar.amount, 0, Hangar.length, Hangar.name));
                int[] hangarXY = getXY();
                Hangar.startX = hangarXY[0];
                Hangar.startY = hangarXY[1];
                Hangar.direction = GetDirection();
                if (CheckPosition(Hangar.length, Hangar.startX, Hangar.startY, Hangar.direction) == true)
                {
                    SetShip("a", Hangar.length, Hangar.startX, Hangar.startY, Hangar.direction);
                }
                else i -= 1;
            }

            Skib Slagskib = new Skib();
            Slagskib.amount = 2;
            Slagskib.length = 4;
            Slagskib.name = "Slagskib";
            for (int i = 0; i < Slagskib.amount; i++)
            {
                if(i == 0){id = "b";}
                else{id = "c";}
                Console.WriteLine(ShipPlacingMessage(Slagskib.amount, i, Slagskib.length, Slagskib.name));
                int[] slagskibXY = getXY();
                Slagskib.startX = slagskibXY[0];
                Slagskib.startY = slagskibXY[1];
                Slagskib.direction = GetDirection();
                if(CheckPosition(Slagskib.length, Slagskib.startX, Slagskib.startY, Slagskib.direction) == true)
                {
                    SetShip(id, Slagskib.length, Slagskib.startX, Slagskib.startY, Slagskib.direction);
                }
                else i -= 1;
            }

            Skib Destroyer = new Skib();
            Destroyer.amount = 2;
            Destroyer.length = 3;
            Destroyer.name = "Destroyer";
            for (int i = 0; i < Destroyer.amount; i++)
            {
                if (i == 0) { id = "d"; }
                else{id = "e";}
                Console.WriteLine(ShipPlacingMessage(Destroyer.amount, i, Destroyer.length, Destroyer.name));
                int[] DestroyerXY = getXY();
                Destroyer.startX = DestroyerXY[0];
                Destroyer.startY = DestroyerXY[1];
                Destroyer.direction = GetDirection();
                if(CheckPosition(Destroyer.length, Destroyer.startX, Destroyer.startY, Destroyer.direction) == true)
                {
                    SetShip(id, Destroyer.length, Destroyer.startX, Destroyer.startY, Destroyer.direction);
                }
                else i -= 1;
            }
            
            Skib Uboat = new Skib();
            Uboat.amount = 1;
            Uboat.length = 3;
            Uboat.name = "Uboat";
            for (int i = 0; i < Uboat.amount; i++)
            {
                id = "f";
                Console.WriteLine(ShipPlacingMessage(Uboat.amount, 0, Uboat.length, Uboat.name));
                int[] UboatXY = getXY();
                Uboat.startX = UboatXY[0];
                Uboat.startY = UboatXY[1];
                Uboat.direction = GetDirection();
                if (CheckPosition(Uboat.length, Uboat.startX, Uboat.startY, Uboat.direction) == true)
                {
                    SetShip(id, Uboat.length, Uboat.startX, Uboat.startY, Uboat.direction);
                }
                else i -= 1;
            }
            

            Skib PatrolBoat = new Skib();
            PatrolBoat.amount = 3;
            PatrolBoat.length = 2;
            PatrolBoat.name = "PatrolBoat";
            for (int i = 0; i < PatrolBoat.amount; i++)
            {
                if (i == 0) { id = "g"; }
                else if (i == 1) { id = "h"; }
                else { id = "i"; }
                Console.WriteLine(ShipPlacingMessage(PatrolBoat.amount, i, PatrolBoat.length, PatrolBoat.name));
                int[] PatrolBoatXY = getXY();
                PatrolBoat.startX = PatrolBoatXY[0];
                PatrolBoat.startY = PatrolBoatXY[1];
                PatrolBoat.direction = GetDirection();
                if(CheckPosition(PatrolBoat.length, PatrolBoat.startX, PatrolBoat.startY, PatrolBoat.direction) == true)
                {
                    SetShip(id, PatrolBoat.length, PatrolBoat.startX, PatrolBoat.startY, PatrolBoat.direction);
                }
                else i -= 1;
            }

            if(gameVariation == 1)
            {
                Skib Mine = new Skib();
                Mine.amount = 10;
                Mine.length = 1;
                Mine.name = "Mine";
                id = "m";
                for (int i = 0; i < Mine.amount; i++)
                {
                    Console.WriteLine(ShipPlacingMessage(Mine.amount, i, Mine.length, Mine.name));
                    int[] MineXY = getXY();
                    Mine.startX = MineXY[0];
                    Mine.startY = MineXY[1];
                    Mine.direction = 1;
                    if (CheckPosition(Mine.length, Mine.startX, Mine.startY, Mine.direction) == true)
                    {
                        SetShip(id, Mine.length, Mine.startX, Mine.startY, Mine.direction);
                    }
                    else i -= 1;       
                }
            }
            numberOfPlays++;
        }

        public string ShipPlacingMessage(int amout, int loopValue, int lenght, string name)
        {
            return "You are placing a " + name + ". It's length is: " + lenght + ".\n" +
                                  "You have " + (amout - loopValue) + " " + name + " left.";
        }

        
        public bool CheckPosition(int shipLenght, int startX, int startY, int direction)
        {
            bool isOverlap = false;

            if (direction == 1 || direction == 3)//1north/3south
            {
                if(direction == 3)
                {
                    startY -= (shipLenght-1);
                    if(startY - (shipLenght-1) < 0)
                    {
                        isOverlap = true;
                        Console.WriteLine("The ship must be ON the board!");
                    }
                }
                else
                {
                    if(startY + (shipLenght-1) > 10)
                    {
                        isOverlap = true;
                        Console.WriteLine("The ship must be ON the board!");
                    }
                }
                for (int i = 0; i < shipLenght; i++)
                {
                    if(CurrentPlayerBoard()[startX, startY + i] != ' ')
                    {
                        isOverlap = true;
                        Console.WriteLine("Your ships can NOT overlap!");
                    }
                }
            }
            if(direction == 2 || direction == 4)//east/west
            {
                if(direction == 2)
                {
                    if(startX + (shipLenght-1) > 10)
                    {//out of bounds
                        isOverlap = true;
                        Console.WriteLine("The ship must be ON the board!");
                    }
                }
                else
                {
                    startX -= (shipLenght - 1);
                    if (startX - (shipLenght - 1) < 0)
                    {//out of bounds
                        isOverlap = true;
                        Console.WriteLine("The ship must be ON the board!");
                    }
                }
                for (int i = 0; i < shipLenght; i++)
                {
                    if(CurrentPlayerBoard()[startX + i, startY] != ' ')
                    {
                        isOverlap = true;
                        Console.WriteLine("Your ships can NOT overlap!");
                    }
                }
            }

            return !isOverlap;
        }

        public void SetShip(string name, int shipLength, int startX, int startY, int direction)
        {
            char init = name[0];
            if(direction == 1 || direction == 3)//1 north -- 3 south
            {
                if(direction == 3)
                {
                    startY -= (shipLength - 1);
                }
                for (int i = 0; i < shipLength; i++)
                {
                    CurrentPlayerBoard()[startX, startY + i] = init;
                }
            }
            if(direction == 2 || direction == 4)//2 east -- 4 west
            {
                if(direction == 4)
                {
                    startX -= (shipLength - 1);
                }
                for (int i = 0; i < shipLength; i++)
                {
                    CurrentPlayerBoard()[startX + i, startY] = init;
                }
            }
            Console.Clear();//make method
            Console.WriteLine(GetGameBoardViewLayDown(CurrentPlayerBoard()));
        }

        public int GetDirection()
        {
            bool continueLoop = true;
            int dirValue = 0;
            while (continueLoop)
            {
                Console.WriteLine("Hvilke retning skal skibet være?\n1 = Nord -- 2 = East -- 3 = South -- 4 = West");
                try
                {
                    dirValue = Convert.ToInt32(Console.ReadLine());
                    if (dirValue < 1 || dirValue > 4)
                    {
                        Console.WriteLine("Selection is not valid");
                    }
                    else
                    {
                        continueLoop = false;
                    }
                }
                catch
                {
                    Console.WriteLine("Selection is not valid");
                }                
            }
            return dirValue;
        }


        public void MakeMsg(int player)
        {
            Console.Clear();
            string s = "__   __                            _                  _     _       _ \n";
            s += "\\ \\ / /                           | |                | |   (_)     | |\n";
            s += " \\ V /___  _   _   ___ _   _ _ __ | | __   __ _   ___| |__  _ _ __ | |\n";
            s += "  \\ // _ \\| | | | / __| | | | '_ \\| |/ /  / _` | / __| '_ \\| | '_ \\| |\n";
            s += "  | | (_) | |_| | \\__ \\ |_| | | | |   <  | (_| | \\__ \\ | | | | |_) |_|\n";
            s += "  \\_/\\___/ \\__,_| |___/\\__,_|_| |_|_|\\_\\  \\__,_| |___/_| |_|_| .__/(_)\n";
            s += "                                                             | |      \n";
            s += "                                                             |_|      \n";
            if(player == 1)
            {
                Console.WriteLine(s + "\nYou have: " + player2ShipsLeft + " ships left to sink!");
            }
            else
            {
                Console.WriteLine(s + "\nYou have: " + player1ShipsLeft + " ships left to sink!");
            }
            
        }

        public int[] getXY()    //gets x and y values 
        {
            int[] values = new int[2];
            int xVal = 0;
            int yVal = 0;
            bool gotX = true;
            bool gotY = true;
            while (gotX)
            {
                Console.Write("Select A - J: ");

                switch (Console.ReadLine().Trim().ToUpper().ToString())
                {
                    case "A":
                        xVal = 1; gotX = false;
                        break;
                    case "B":
                        xVal = 2; gotX = false;
                        break;
                    case "C":
                        xVal = 3; gotX = false;
                        break;
                    case "D":
                        xVal = 4; gotX = false;
                        break;
                    case "E":
                        xVal = 5; gotX = false;
                        break;
                    case "F":
                        xVal = 6; gotX = false;
                        break;
                    case "G":
                        xVal = 7; gotX = false;
                        break;
                    case "H":
                        xVal = 8; gotX = false;
                        break;
                    case "I":
                        xVal = 9; gotX = false;
                        break;
                    case "J":
                        xVal = 10; gotX = false;
                        break;
                    default:
                        Console.WriteLine("Selection is not valid");
                        break;
                }
            }
            while (gotY)
            {
                Console.Write("Select 1 - 10: ");
                try
                {
                    yVal = Convert.ToInt32(Console.ReadLine());
                    if (yVal < 1 || yVal > 10)
                    {
                        Console.WriteLine("Selection is not valid");
                    }
                    else
                    {
                        gotY = false;
                    }
                }
                catch
                {
                    Console.WriteLine("Selection is not valid");
                }
            }
            values[0] = xVal - 1;//good for putting down coordinates in 0based index
            values[1] = yVal - 1;//not as good when writing out to player
            return values;      //either work out here or whenever it's printed
        }
    }
}
