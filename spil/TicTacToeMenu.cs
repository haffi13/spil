using System;

namespace spil
{
    public class TicTacToeMenu
    {
        TicTacToe ticTacToe {get; set; }
        public void Show()
        {
            bool running = true;            
            string choice = "";
            do
            {
                ShowMenu();
                choice = GetUserChoise();
                switch (choice)
                {
                    case "1": DoActionFor1(); break;
                    case "2": DoActionFor2(); break;
                    case "3": DoActionFor3(); break;
                    case "0": running = false; DoActionFor0(); break;
                    default : ShowMenuSelectionError(); break;
                }
            } while (running);
        }

        public void GameModeSelect() //used by place and move in TicTacToe to determine game mode
        {
            int gameMode;
            Console.WriteLine("Select game mode: \n\n  1: 3 Bricks \n  2: Unlimited");
            while (true)
            {
                try
                {
                    gameMode = Convert.ToInt32(Console.ReadLine().Trim());
                    if(gameMode == 1 || gameMode == 2)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Selection is not valid!");
                    }
                }
                catch
                {
                    Console.WriteLine("Selection is not valid!");
                }
            }
            ticTacToe.gameMode = gameMode;
        }

        private void ShowMenu()
        {
            Console.Clear();
            if (ticTacToe != null)
            {
                Console.WriteLine(ticTacToe.GetGameBoardView());
            }
            Console.WriteLine("tic tac toe");
            Console.WriteLine();
            Console.WriteLine("1. Oret nyt spil");
            Console.WriteLine("2. Set en brik");
            Console.WriteLine("3. Flyt en brik\n");
            Console.WriteLine("0. exit");
            if(ticTacToe.currentPlayer == ' ' || ticTacToe.currentPlayer == 'X')
            {
                Console.WriteLine("\n--- X ----");
            }
            else
            {
                Console.WriteLine("\n--- O ---");
            }
        }

        private string GetUserChoise()
        {
            Console.Write("\nIndtast dit valg: ");
            return Console.ReadLine();
        }

        private void ShowMenuSelectionError()
        {
            Console.WriteLine("Ugyldigt valg.");
            Console.ReadLine();
            Console.WriteLine("brajj");
        }

        public void DoActionFor1()
        {
            ticTacToe = new TicTacToe();
            Console.Clear();
            GameModeSelect();
            Console.WriteLine(ticTacToe.GetGameBoardView());
            Show();
        }
        private void DoActionFor2()
        {
            ticTacToe.GetPlacement();
            ShowMenu();
        }
        
        private void DoActionFor3()
        {
            ticTacToe.ChangePlacement();
            ShowMenu();
        }

        private void DoActionFor0()
        {
            Environment.Exit(0);
        }
    }
}