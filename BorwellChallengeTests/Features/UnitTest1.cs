using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//Test Driven Design for The Room Calculations.
//Tests Needed:
//Check Dimensions entered by user are valid.
//Calculate Area
//Calculate PaintRequired
//Calculate Volume

namespace BorwellChallengeTests
{
    //areDimensionsValid() method testing.
    //Test that all of the properties of room are greater than 0.
    [TestClass]
    public class areDimensionsValidTests
    {

        [TestMethod]
        public void validDimensions()
        {
            decimal width = 1;
            decimal length = 1;
            decimal height = 1;
            var data = new Room(width, length, height);

            Assert.IsTrue(data.areDimensionsValid());
        }
    }
}
