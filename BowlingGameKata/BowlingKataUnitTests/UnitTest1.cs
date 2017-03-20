using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGameKata;

namespace BowlingKataUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        private Game g;

        public UnitTest1()
        {
            g = new Game();
        }
           

        [TestMethod]
        public void DoesGameExist()
        {
            //arrange
            

            //act
           

            //assert
            Assert.IsNotNull(g);
        }

        [TestMethod]
        public void GutterGameReturns0()
        {
            //arrange

            int pins = 0;

            //act
           


            //assert
            Assert.AreEqual(0, g.scoreGame());
        }

        [TestMethod]
        public void singlePinGameReturns20()
        {
            //arrange

            //act
            rollMany(20, 1);
           


            //assert
            Assert.AreEqual(20, g.scoreGame());
        }


        public void rollMany(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)

            {
                g.roll(pins);
            }
        }


    }
}
