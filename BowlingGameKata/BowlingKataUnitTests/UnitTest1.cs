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

            //act
            rollMany(20, 0);

           
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

        //[TestMethod]
        //public void OneSPareReturnAppropriateValue()
        //{
        //    //arrange
        //    g.roll(5);
        //    g.roll(5); //spare
        //    g.roll(3);

        //    //act
        //    rollMany(17, 0);

        //    //assert
        //    Assert.AreEqual(16, g.scoreGame());
        //}


        public void rollMany(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)

            {
                g.roll(pins);
            }
        }


    }
}
