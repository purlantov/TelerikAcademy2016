using System;
using MatrixWalk;
using NUnit.Framework;

namespace TestMatrix
{
    [TestFixture]
    public class MatrixTest
    {
        [Test]
        public void CheckIfConstructorWorksAndMakeInstanceOfMatrix()
        {
            MatrixRotatingWalk matrix = new MatrixRotatingWalk(2);
            Assert.IsInstanceOf<MatrixRotatingWalk>(matrix);
        }

        [TestCase(1,1)]
        [TestCase(2,2)]
        [TestCase(5,5)]
        [TestCase(10,10)]
        public void CheckIfConstructorSetRightAmountOfDimentionsTest(int dimmension, int expectedResult)
        {
            MatrixRotatingWalk matrix = new MatrixRotatingWalk(dimmension);
            Assert.AreEqual(matrix.Dimentions, expectedResult);
        }

        [Test]
        public void NegativeDimentionsTest()
        {
            MatrixRotatingWalk matrix;
            Assert.Throws<ArgumentOutOfRangeException>(() => matrix = new MatrixRotatingWalk(-1));

        }

        [Test]
        public void TooBigDimentionsTest()
        {
            MatrixRotatingWalk matrix;
            Assert.Throws<ArgumentOutOfRangeException>(() => matrix = new MatrixRotatingWalk(101));
        }

        [Test]
        public void OneDimentionTest()
        {
            MatrixRotatingWalk matrix = new MatrixRotatingWalk(1);

            Assert.IsTrue(matrix.ToString() == string.Format("  1{0}", Environment.NewLine));
        }

        [Test]
        public void TwoDimentionTest()
        {
            MatrixRotatingWalk matrix = new MatrixRotatingWalk(2);

            Assert.IsTrue(matrix.ToString() == string.Format("  1  4{0}  3  2{0}", Environment.NewLine));
        }

        [Test]
        public void ThreeDimentionTest()
        {
            MatrixRotatingWalk matrix = new MatrixRotatingWalk(3);

            Assert.AreEqual(matrix.ToString(), string.Format("  1  7  8{0}  6  2  9{0}  5  4  3{0}", Environment.NewLine));
        }

        [Test]
        public void SixDimentionTest()
        {
            MatrixRotatingWalk matrix = new MatrixRotatingWalk(6);

            Assert.AreEqual(matrix.ToString(), string.Format("{0}{6}{1}{6}{2}{6}{3}{6}{4}{6}{5}{6}",
                                                            "  1 16 17 18 19 20",
                                                            " 15  2 27 28 29 21",
                                                            " 14 31  3 26 30 22",
                                                            " 13 36 32  4 25 23",
                                                            " 12 35 34 33  5 24",
                                                            " 11 10  9  8  7  6",
                                                            Environment.NewLine));
        }
    }
}