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
            ScoreMaker whiteTest = new ScoreMaker();
            decimal result = whiteTest.scoreCalculator();
            Assert.AreEqual(100, result);
        }

        [Test]
        public void ImageIsBlack()
        {
            ScoreMaker blackTest = new ScoreMaker();
            decimal result = blackTest.scoreCalculator();
            Assert.AreEqual(0, result);
        }

        [Test]
        public void ImageIsBlackAndWhite()
        {
            ScoreMaker black_white = new ScoreMaker();
            decimal result = black_white.scoreCalculator();
            Assert.AreEqual(50, result);
        }
    }
}
