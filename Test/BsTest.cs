using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    [TestClass]
    public class BsTest 
    {
        //public Battleships battleships;
        public char[,] testArr { get; set; }

        [TestInitialize]
        public void setuptest()
        {
            testArr = new char[10, 10]
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

        [TestMethod]
        public void DoesWinningClearBoards()
        {
            Battleships bs = new Battleships();
            bs.player2ships[5, 9] = 'g';
            bs.ValidateWinner(28, 19);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Assert.AreEqual(testArr[i, j], bs.player2ships[i, j]);
                }
            }
        }

        [TestMethod]
        public void DoesBoardInstansiationWork()
        {
            Battleships bs = new Battleships();
            //bs.InstansiateBoards();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Assert.AreEqual(testArr[i, j], bs.player1ships[i, j]);
                }
            }   
        }

        [TestMethod]
        public void test()
        {
            Battleships bs = new Battleships();

            bs.SetShip("bla", 2, 1, 1, 1);
            

        }
    }
}