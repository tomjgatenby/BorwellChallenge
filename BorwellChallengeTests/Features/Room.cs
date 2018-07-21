using System;

namespace BorwellChallengeTests
{
    internal class Room
    {
        private decimal width;
        private decimal length;
        private decimal height;

        public Room(decimal width, decimal length, decimal height)
        {
            this.width = width;
            this.length = length;
            this.height = height;
        }

        internal bool areDimensionsValid()
        {
            return true;
        }
    }
}