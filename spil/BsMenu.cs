using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    class BsMenu : Program     //if stack overflow check me!!!
    {
        
        Battleships battleships = new Battleships();
        public void ShowBsMenu()
        {
            bool running = true;
            string choice = "";
            do
            {
                //ShowMenu();
                choice = GetUserChoise();
                switch (choice)
                {
                    case "1": PlaceShips(); break;
                    case "2": PlaceShot(); break;                                            
                    case "3": StartOver(); break;          //startOVer
                    case "0": ExitGame(); break;          //Exit
                    //case "0": running = false; DoActionFor0(); break;
                    default: break; // ShowMenuSelectionError(); break;
                }
            } while (running);
        }

        

        

        private string GetUserChoise()
        {
            Console.Clear();
            Console.WriteLine(battleships.GetGameBoardViewBs(battleships.CurrentPlayer()));
            Console.WriteLine("1  -  Place Ships\n2  -  Place a shot\n0  -  Quit Game");
            Console.Write("\nIndtast dit valg: ");
            return Console.ReadLine();
        }

        public void PlaceShot()
        {

        }
        public void PlaceShips()
        {//placesShips
            Console.Clear();
            Console.WriteLine(battleships.GetGameBoardViewBs(battleships.player1ships));
            battleships.PlaceShips();
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
