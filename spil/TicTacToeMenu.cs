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
                    case "1": DoActionFor1(); running = false; break;
                    case "2": DoActionFor2(); break;
                    case "3": DoActionFor3(); break;
                    case "0": running = false; break;
                    default : ShowMenuSelectionError(); break;
                }
            } while (running);
        }

        private void ShowMenu()
        {
            //Console.Clear();
            if (ticTacToe != null)
            {
                Console.WriteLine(ticTacToe.GetGameBoardView());
            }
            Console.WriteLine("tic tac toe");
            Console.WriteLine();
            Console.WriteLine("1. Oret nyt spil");
            Console.WriteLine("2. Set en brik");
            Console.WriteLine("3. Flyt en brik");
            Console.WriteLine();
            Console.WriteLine("0. exit");
        }

        private string GetUserChoise()
        {
            Console.WriteLine();
            Console.Write("Indtast dit valg: ");
            return Console.ReadLine();
        }

        private void ShowMenuSelectionError()
        {
            Console.WriteLine("Ugyldigt valg.");
            Console.ReadLine();

        }

        private void DoActionFor1()
        {
            TicTacToe tic = new TicTacToe();        //not correct,should clear selections
            Console.Clear();
            Console.WriteLine(tic.GetGameBoardView());
            //Console.WriteLine("skriv koden til at opret nyt spil");
            //Console.ReadLine();
            DoActionFor2();
        }
        private void DoActionFor2()
        {
            int xVal;
            int yVal;
            Console.Write("Select X: ");
            xVal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Select Y: ");
            yVal = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("skriv koden til at få spillerens input til at sætte en brik");
            TicTacToe tic = new TicTacToe();
            tic.GameBoard[xVal, yVal] = 'x';
            //Console.ReadLine();
            DoActionFor1();
        }
        private void DoActionFor3()
        {
            Console.WriteLine("skriv koden til at få spillerens input til at flytte en brik");
            Console.ReadLine();
        }
    }
}