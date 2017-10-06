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
        public string GetGameBoardView(char[,] curr)
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
            Console.WriteLine("hello");
            return boardLayout;
        }
    }
}
