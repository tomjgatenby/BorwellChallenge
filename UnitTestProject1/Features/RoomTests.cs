using System;
using BorwellChallengeTests.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;


//Test Driven Design for The Room Calculations.
//Tests Needed:
//Check Dimensions entered by user are valid.
//Calculate Area
//Calculate PaintRequired
//Calculate Volume

namespace BorwellChallengeTests
{
    //AreDimensionsValid() method testing.
    //Test that all of the properties of room are greater than 0.
    [TestClass]
    public class AreDimensionsValidTests
    {

        [TestMethod]
        public void ValidDimensions()
        {
            decimal width = 1;
            decimal length = 1;
            decimal height = 1;
            var data = new Room(width, length, height);

            Assert.IsTrue(data.AreDimensionsValid());
        }

        [TestMethod]
        public void InvalidWidth()
        {
            decimal width = 0;
            decimal length = 1;
            decimal height = 1;
            var data = new Room(width, length, height);

            Assert.IsFalse(data.AreDimensionsValid());
        }

        [TestMethod]
        public void InvalidLength()
        {
            decimal width = 1;
            decimal length = 0;
            decimal height = 1;
            var data = new Room(width, length, height);

            Assert.IsFalse(data.AreDimensionsValid());
        }

        [TestMethod]
        public void InvalidHeight()
        {
            decimal width = 1;
            decimal length = 1;
            decimal height = 0;
            var data = new Room(width, length, height);

            Assert.IsFalse(data.AreDimensionsValid());
        }

        [TestMethod]
        public void InvalidDimension()
        {
            decimal width = 0;
            decimal length = -1;
            decimal height = 2;
            var data = new Room(width, length, height);

            Assert.IsFalse(data.AreDimensionsValid());

        }
    }

    //Calculates the Area of the room using width and length properties.
    //Taken the decision to round to 3 decimal places.
    [TestClass]
    public class CalculateAreaTests
    {
        [TestMethod]
        public void IntegerMultiplication()
        {
            decimal width = 1;
            decimal length = 1;
            decimal height = 1;
            var data = new Room(width, length, height);

            Assert.AreEqual(1, data.CalculateArea());

        }

        [TestMethod]
        public void DecimalMultiplication()
        {
            decimal width = 1.5M;
            decimal length = 2;
            decimal height = 1;
            var data = new Room(width, length, height);

            Assert.AreEqual(3, data.CalculateArea());

        }

        [TestMethod]
        public void DecimalRoundingTest()
        {
            decimal width = 1.222222222222M;
            decimal length = 1;
            decimal height = 1;
            var data = new Room(width, length, height);

            Assert.AreEqual(1.222M, data.CalculateArea());
        }

    }
    //Calculates the Paint Required for a room.
    //Taken the decision to round to 3 decimal places.
    [TestClass]
    public class PaintRequiredTests
    {
        [TestMethod]
        public void Test1()
        {
            decimal width = 1;
            decimal length = 1;
            decimal height = Room.SqMeterPerPaintLitre; //Set this to height so division doesn't need rounding.
            var data = new Room(width, length, height);
            decimal wallArea = (4 * height); //perimeter = 4
            decimal expected = (wallArea / Room.SqMeterPerPaintLitre);
            Assert.AreEqual(expected, data.CalculatePaintRequired());
        }

        [TestMethod]
        public void Test2()
        {
            decimal width = 2;
            decimal length = 2;
            decimal height = 2;
            var data = new Room(width, length, height);
            decimal wallArea = 16; //perimeter = 8, * 2 from height
            decimal expected = (wallArea / Room.SqMeterPerPaintLitre);
            expected = Math.Round(expected, 3);
            Assert.AreEqual(expected, data.CalculatePaintRequired());
        }
    }

    //Calculates the volume of a room.
    //Taken the decision to round to 3 decimal places
    [TestClass]
    public class CalculateVolumeTests
    {
        [TestMethod]
        public void IntegerMultiplication()
        {
            decimal width = 1;
            decimal length = 1;
            decimal height = 1;
            var data = new Room(width, length, height);
            Assert.AreEqual(1, data.CalculateVolume());
        }

        [TestMethod]
        public void DecimalMultiplication()
        {
            decimal width = 1.5M;
            decimal length = 2;
            decimal height = 1.5M;
            var data = new Room(width, length, height);
            Assert.AreEqual(4.5M, data.CalculateVolume());
        }

        [TestMethod]
        public void DecimalRounding()
        {
            decimal width = 1.22222M;
            decimal length = 1;
            decimal height = 1;
            var data = new Room(width, length, height);
            Assert.AreEqual(1.222M, data.CalculateVolume());
        }
    }
}
