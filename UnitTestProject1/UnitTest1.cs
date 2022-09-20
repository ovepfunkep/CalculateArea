using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AreaCalculator;
using AreaCalculator.Shapes;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTriangleWithoutSides()
        {
            //arrange
            Shape shape = new Triangle();

            //act
            double expected = 0;

            //assert
            Assert.AreEqual(expected, shape.Area);
        }

        [TestMethod]
        public void TestTriangleWithLessThan3Sides()
        {
            //arrange
            Shape shape = new Triangle(2,3);

            //act
            double expected = 0;

            //assert
            Assert.AreEqual(expected, shape.Area);
        }

        [TestMethod]
        public void TestTriangleWithAllSides()
        {
            //arrange
            Shape shape = new Triangle(3, 4, 5);

            //act
            double expected = 6;

            //assert
            Assert.AreEqual(expected, shape.Area);
        }

        [TestMethod]
        public void TestTriangleIsRectangular()
        {
            //arrange
            Shape shape = new Triangle(3, 4, 6);

            //assert
            Assert.IsFalse(((Triangle)shape).Rectangular);
        }

        [TestMethod]
        public void TestTriangleIsNotRectangular()
        {
            //arrange
            Shape shape = new Triangle(3, 4, 5);

            //assert
            Assert.IsTrue(((Triangle)shape).Rectangular);
        }

        [TestMethod]
        public void TestCircleWithR()
        {
            //arrange
            Shape shape = new Circle(1);

            //act
            double expected = Math.PI;

            //assert
            Assert.AreEqual(expected, shape.Area);
        }

        [TestMethod]
        public void TestCircleWithoutR()
        {
            //arrange
            Shape shape = new Circle();

            //act
            double expected = 0;

            //assert
            Assert.AreEqual(expected, shape.Area);
        }

        [TestMethod]
        public void TestUnknownFigure()
        {
            //arrange
            Shape shape = new Shape(new Triangle(3, 4, 5));

            //act
            double expected = 6;

            //assert
            Assert.AreEqual(expected, shape.Area);
        }

        [TestMethod]
        public void TestNullFigure()
        {
            //arrange
            Shape shape = new Shape();

            //act
            double expected = 0;

            //assert
            Assert.AreEqual(expected, shape.Area);
        }
    }
}
