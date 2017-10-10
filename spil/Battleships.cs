using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    class Battleships
    {
        public char[,] player1ships { get; set; }
        public char[,] player2ships { get; set; }
        public int numberOfPlays = 0;

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
        }
        public string GetGameBoardViewBs(char[,] curr)
        {
            string boardLayout = string.Empty;

            boardLayout += "   *************************************************************\n";
            boardLayout += "   *     *     *     *     *     *     *     *     *     *     *\n";
            boardLayout += "10 *  " + curr[0, 9] + "  *  " + curr[1, 9] + "  *  " + curr[2, 9] + "  *  " + curr[3, 9] + "  *  " + curr[4, 9] + "  *  " + curr[5, 9] + "  *  " + curr[6, 9] + "  *  " + curr[7, 9] + "  *  " + curr[8, 9] + "  *  " + curr[9, 9] + "  *\n";
            boardLayout += "   *     *     *     *     *     *     *     *     *     *     *\n";
            boardLayout += "   *************************************************************\n";
            boardLayout += "   *     *     *     *     *     *     *     *     *     *     *\n";
            boardLayout += " 9 *  " + curr[0, 8] + "  *  " + curr[1, 8] + "  *  " + curr[2, 8] + "  *  " + curr[3, 8] + "  *  " + curr[4, 8] + "  *  " + curr[5, 8] + "  *  " + curr[6, 8] + "  *  " + curr[7, 8] + "  *  " + curr[8, 8] + "  *  " + curr[9, 8] + "  *\n";
            boardLayout += "   *     *     *     *     *     *     *     *     *     *     *\n";
            boardLayout += "   *************************************************************\n";
            boardLayout += "   *     *     *     *     *     *     *     *     *     *     *\n";
            boardLayout += " 8 *  " + curr[0, 7] + "  *  " + curr[1, 7] + "  *  " + curr[2, 7] + "  *  " + curr[3, 7] + "  *  " + curr[4, 7] + "  *  " + curr[5, 7] + "  *  " + curr[6, 7] + "  *  " + curr[7, 7] + "  *  " + curr[8, 7] + "  *  " + curr[9, 7] + "  *\n";
            boardLayout += "   *     *     *     *     *     *     *     *     *     *     *\n";
            boardLayout += "   *************************************************************\n";
            boardLayout += "   *     *     *     *     *     *     *     *     *     *     *\n";
            boardLayout += " 7 *  " + curr[0, 6] + "  *  " + curr[1, 6] + "  *  " + curr[2, 6] + "  *  " + curr[3, 6] + "  *  " + curr[4, 6] + "  *  " + curr[5, 6] + "  *  " + curr[6, 6] + "  *  " + curr[7, 6] + "  *  " + curr[8, 6] + "  *  " + curr[9, 6] + "  *\n";
            boardLayout += "   *     *     *     *     *     *     *     *     *     *     *\n";
            boardLayout += "   *************************************************************\n";
            boardLayout += "   *     *     *     *     *     *     *     *     *     *     *\n";
            boardLayout += " 6 *  " + curr[0, 5] + "  *  " + curr[1, 5] + "  *  " + curr[2, 5] + "  *  " + curr[3, 5] + "  *  " + curr[4, 5] + "  *  " + curr[5, 5] + "  *  " + curr[6, 5] + "  *  " + curr[7, 5] + "  *  " + curr[8, 5] + "  *  " + curr[9, 5] + "  *\n";
            boardLayout += "   *     *     *     *     *     *     *     *     *     *     *\n";
            boardLayout += "   *************************************************************\n";
            boardLayout += "   *     *     *     *     *     *     *     *     *     *     *\n";
            boardLayout += " 5 *  " + curr[0, 4] + "  *  " + curr[1, 4] + "  *  " + curr[2, 4] + "  *  " + curr[3, 4] + "  *  " + curr[4, 4] + "  *  " + curr[5, 4] + "  *  " + curr[6, 4] + "  *  " + curr[7, 4] + "  *  " + curr[8, 4] + "  *  " + curr[9, 4] + "  *\n";
            boardLayout += "   *     *     *     *     *     *     *     *     *     *     *\n";
            boardLayout += "   *************************************************************\n";
            boardLayout += "   *     *     *     *     *     *     *     *     *     *     *\n";
            boardLayout += " 4 *  " + curr[0, 3] + "  *  " + curr[1, 3] + "  *  " + curr[2, 3] + "  *  " + curr[3, 3] + "  *  " + curr[4, 3] + "  *  " + curr[5, 3] + "  *  " + curr[6, 3] + "  *  " + curr[7, 3] + "  *  " + curr[8, 3] + "  *  " + curr[9, 3] + "  *\n";
            boardLayout += "   *     *     *     *     *     *     *     *     *     *     *\n";
            boardLayout += "   *************************************************************\n";
            boardLayout += "   *     *     *     *     *     *     *     *     *     *     *\n";
            boardLayout += " 3 *  " + curr[0, 2] + "  *  " + curr[1, 2] + "  *  " + curr[2, 2] + "  *  " + curr[3, 2] + "  *  " + curr[4, 2] + "  *  " + curr[5, 2] + "  *  " + curr[6, 2] + "  *  " + curr[7, 2] + "  *  " + curr[8, 2] + "  *  " + curr[9, 2] + "  *\n";
            boardLayout += "   *     *     *     *     *     *     *     *     *     *     *\n";
            boardLayout += "   *************************************************************\n";
            boardLayout += "   *     *     *     *     *     *     *     *     *     *     *\n";
            boardLayout += " 2 *  " + curr[0, 1] + "  *  " + curr[1, 1] + "  *  " + curr[2, 1] + "  *  " + curr[3, 1] + "  *  " + curr[4, 1] + "  *  " + curr[5, 1] + "  *  " + curr[6, 1] + "  *  " + curr[7, 1] + "  *  " + curr[8, 1] + "  *  " + curr[9, 1] + "  *\n";
            boardLayout += "   *     *     *     *     *     *     *     *     *     *     *\n";
            boardLayout += "   *************************************************************\n";
            boardLayout += "   *     *     *     *     *     *     *     *     *     *     *\n";
            boardLayout += " 1 *  " + curr[0, 0] + "  *  " + curr[1, 0] + "  *  " + curr[2, 0] + "  *  " + curr[3, 0] + "  *  " + curr[4, 0] + "  *  " + curr[5, 0] + "  *  " + curr[6, 0] + "  *  " + curr[7, 0] + "  *  " + curr[8, 0] + "  *  " + curr[9, 0] + "  *\n";
            boardLayout += "   *     *     *     *     *     *     *     *     *     *     *\n";
            boardLayout += "   *************************************************************\n";
            boardLayout += "      A     B     C     D     E     F     G     H     I     J";

            return boardLayout;
        }

        public char[,] CurrentPlayer()
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

        public void PlaceShips()
        //9 total ships per player
        {
            Skib Hangar = new Skib();
            Hangar.amount = 1;
            Hangar.length = 5;
            
            Hangar.name = "Hangar";
            int[] hangarXY = getXY();
            Hangar.startX = hangarXY[0];
            Hangar.startY = hangarXY[1];
            //Hangar.direction = GetDirection();
            SetShip(Hangar.name, Hangar.length, Hangar.startX, Hangar.startY, Hangar.direction);
            
            


            /*Skib Slagskib = new Skib();
            Slagskib.amount = 2;
            Slagskib.length = 4;
            Slagskib.name = "Slagskib";
            
                int[] slagskibXY = ttt.getXY();
                Slagskib.startX = slagskibXY[0];
                Slagskib.startY = slagskibXY[1];
                SetShip(Slagskib.length, Slagskib.startX, Slagskib.startY);
            


            Skib Destroyer = new Skib();
            Destroyer.amount = 2;
            Destroyer.length = 3;
            Destroyer.name = "Destroyer";
            
                int[] DestroyerXY = ttt.getXY();
                Destroyer.startX = DestroyerXY[0];
                Destroyer.startY = DestroyerXY[1];
                SetShip(Destroyer.length, Destroyer.startX, Destroyer.startY);
            
            

            Skib Uboat = new Skib();
            Uboat.amount = 1;
            Uboat.length = 3;
            Uboat.name = "Uboat";
            
                int[] UboatXY = ttt.getXY();
                Uboat.startX = UboatXY[0];
                Uboat.startY = UboatXY[1];
                SetShip(Uboat.length, Uboat.startX, Uboat.startY);
            

            Skib PatrolBoat = new Skib();
            PatrolBoat.amount = 3;
            PatrolBoat.length = 2;
            PatrolBoat.name = "PatrolBoat";
            int[] PatrolBoatXY = getXY();
            PatrolBoat.startX = PatrolBoatXY[0];
            PatrolBoat.startY = PatrolBoatXY[1];*/

        }

        public void SetShip(string name, int shipLenght, int startX, int startY, int direction)
        {
            char init = name[0];

            if(direction == 1 || direction == 3)//north/south
            {
                if(direction == 3)
                {
                    startX -= (shipLenght-1);
                }
                for (int i = 0; i < shipLenght; i++)
                {
                    CurrentPlayer()[startX, startY + i] = init;
                }
            }
            if(direction == 2 || direction == 4)//east/west
            {
                if(direction == 2)
                {
                    startY -= (shipLenght-1);
                }
                for (int i = 0; i < shipLenght; i++)
                {
                    CurrentPlayer()[startX + i, startY] = init;
                }
            }
                


            Console.Clear();//make method
            Console.WriteLine(GetGameBoardViewBs(CurrentPlayer()));
            Console.ReadKey();

            //menu.ShootAtShip();
        }

        public int GetDirection()
        {
            bool continueLoop = true;
            while (continueLoop)
            {
                Console.WriteLine("Hvilke retning skal skibet være?\n1 = Nord -- 2 = East -- 3 = South -- 4 = West");
                continueLoop = false;

                
            }
            return 4;
        }

        
          
        /*public bool CheckPosition()
        {//checks for overlap and puts ship on board...calls get ship
            
        }*/

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
