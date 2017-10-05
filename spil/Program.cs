using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }

        private void Run()
        {
            SelectGame();
            
        }

        public void SelectGame()
        {
            Console.WriteLine("1  -  Battleships\n2  -  TicTacToe");
            int sel = Convert.ToInt32(Console.ReadLine());
            if(sel == 1)
            {
                BsMenu menu = new BsMenu();
                menu.Show();
                //menu.PlaceShips();
            }
            else
            {
                TicTacToeMenu menu = new TicTacToeMenu();
                menu.Show();
            }
        }
    }
}
