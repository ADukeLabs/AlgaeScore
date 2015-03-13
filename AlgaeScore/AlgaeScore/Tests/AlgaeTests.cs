using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using BumpKit;

namespace AlgaeScore.Tests
{
    [TestFixture]
    class AlgaeTests
    {
        [Test]
        public void TestTheTester()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void ImageIsWhite()
        {
            //Arrange
            ScoreMaker whiteTest = new ScoreMaker();
            Image whiteImage = Bitmap.FromFile("white.bmp");
            //Act
            decimal result = whiteTest.scoreCalculator(whiteImage);

            //Assert
            Assert.AreEqual(100, result);
        }

        [Test]
        public void ImageIsBlack()
        {
            //Arrange
            ScoreMaker blackTest = new ScoreMaker();
            Image blackImage = Bitmap.FromFile("black.bmp");

            //Act
            decimal result = blackTest.scoreCalculator(blackImage);

            //Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void ImageIsBlackAndWhite()
        {
            //Arrange
            ScoreMaker black_white = new ScoreMaker();
            Image blackAndWhite = Bitmap.FromFile("half.bmp");

            //Act
            decimal result = black_white.scoreCalculator(blackAndWhite); 

            //Assert
            Assert.AreEqual(50, result);
        }
    }
}
