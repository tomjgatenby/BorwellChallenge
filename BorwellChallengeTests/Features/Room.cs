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

        internal bool AreDimensionsValid()
        {
            if (width > 0 && length > 0 && height > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal decimal CalculateArea()
        {
            return 1;
        }
    }
}