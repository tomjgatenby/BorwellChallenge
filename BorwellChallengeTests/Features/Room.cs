using System;

namespace BorwellChallengeTests
{
    internal class Room
    {
        private decimal width;
        private decimal length;
        private decimal height;
        public const int SqMeterPerPaintLitre = 12;

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
            decimal area = (width * length);
            const int decimalPlaces = 3;
            area = Math.Round(area, decimalPlaces);
            return area;
        }

        internal decimal CalculatePaintRequired()
        {
            decimal perimeter = 2 * (width + length);
            decimal wallArea = perimeter * height;
            decimal paintRequired = wallArea / SqMeterPerPaintLitre;
            const int decimalPlaces = 3;
            paintRequired = Math.Round(paintRequired, decimalPlaces);
            return paintRequired;
        }

        internal decimal CalculateVolume()
        {
            return (width * length * height);
        }
    }
}