﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    class BsMenu : Program     
    {
        
        Battleships battleships = new Battleships();
        int placeShipCheck;
        
        public void ShowBsMenu()
        {
            battleships.gameVariation = GetVariation();
            bool running = true;
            string choice = "";
            do
            {
                choice = GetUserChoise();
                switch (choice)                         //make starting over possible
                {
                    case "1": PlaceShips(); break;
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
            if(placeShipCheck != 1)
            {
                if (placeShipCheck >= 2) //game in progress, cant place ships
                {
                    Console.WriteLine("1  -  Start Game\n0  -  Quit Game");
                }

                else
                {
                    Console.WriteLine("1  -  Place Ships\n0  -  Quit Game");
                }
                Console.Write("\nIndtast dit valg: ");
                return Console.ReadLine();
            }
            else
            {
                PlaceShips();
                return string.Empty;
            }
        }

        public int GetVariation()
        {
            bool running = true;
            int sel = 0;
            Console.Clear();
            Console.WriteLine("Select variation: \n1  -  With bombs\n2  -  Without bombs");
            Console.Write("\nIndtast dit valg: ");
            while (running)
            {
                try
                {
                    sel = Convert.ToInt32(Console.ReadLine());
                    if (sel < 0 && sel > 2)
                    {
                        Console.WriteLine("Selection is not valid!");
                    }
                    else running = false;  
                }
                catch
                {
                    Console.WriteLine("Selection is not valid!");
                }
            }
            return sel;
            
        }

        public void PlaceShips()
        {//placesShips
            if(placeShipCheck >= 2)//shoot in here
            {
                battleships.PlaceShot();
            }
            else
            {
                Console.Clear();
                battleships.PlaceShips();
                placeShipCheck++;
                Console.ReadLine();
            }
            
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
