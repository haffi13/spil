using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    class BsMenu : Program      //if stack overflow check me!!!
    {
        
        Battleships battleships = new Battleships();
        public void Show()
        {
            bool running = true;
            string choice = "";
            do
            {
                //ShowMenu();
                choice = GetUserChoise();
                switch (choice)
                {
                    case "1": ShootAtShip(); break;            //shoot
                    case "2": StartOver(); break;          //startOVer
                    case "0": ExitGame(); break;          //Exit
                    //case "0": running = false; DoActionFor0(); break;
                    default: break; // ShowMenuSelectionError(); break;
                }
            } while (running);
        }

        public void PlaceShips()
        {
            
        }

        

        private string GetUserChoise()
        {
            Console.Clear();
            Console.WriteLine("1  -  Shoot\n2  -  Start Over\n0  -  Quit Game");
            Console.Write("\nIndtast dit valg: ");
            return Console.ReadLine();
        }

        private void ShootAtShip()
        {//shoot
            Console.Clear();
            Console.WriteLine(battleships.GetGameBoardView(battleships.player1ships));
            Console.ReadLine();
        }

        public void StartOver()
        {//StartOver
            Console.Clear();
            SelectGame();
        }

        private void ExitGame()
        {//exit
            Environment.Exit(0);
        }
    }
}
