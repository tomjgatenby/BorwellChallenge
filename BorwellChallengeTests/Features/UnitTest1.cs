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
    [TestClass]
    public class UnitTest1
    {
        //areDimenstionsValid() method testing.
        //Test that all of the properties of room are greater than 0.
        [TestMethod]
        public void TestMethod1()
        {
            decimal width = 1;
            decimal length = 1;
            decimal height = 1;
            var data = new Room(width, length, height);

            Assert.IsTrue(data.areDimensionsValid());
        }
    }
}
