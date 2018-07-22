using System;

namespace BorwellChallengeTests.Models
{
    public class Room
    {
        public decimal Width { get; set; }
        public decimal Length { get; set; }
        public decimal Height { get; set; }
        public decimal Area { get { return CalculateArea(); } }
        public decimal PaintRequired { get { return CalculatePaintRequired(); } }
        public decimal Volume { get { return CalculateVolume(); } }
        public bool ValidDimensions { get { return AreDimensionsValid(); } }

        public const int SqMeterPerPaintLitre = 12;

        public Room(decimal width, decimal length, decimal height)
        {
            this.Width = width;
            this.Length = length;
            this.Height = height;
        }


        public bool AreDimensionsValid()
        {
            if (Width > 0 && Length > 0 && Height > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public decimal CalculateArea()
        {
            decimal area = (Width * Length);
            const int decimalPlaces = 3;
            area = Math.Round(area, decimalPlaces);
            return area;
        }

        public decimal CalculatePaintRequired()
        {
            decimal perimeter = 2 * (Width + Length);
            decimal wallArea = perimeter * Height;
            decimal paintRequired = wallArea / SqMeterPerPaintLitre;
            const int decimalPlaces = 3;
            paintRequired = Math.Round(paintRequired, decimalPlaces);
            return paintRequired;
        }

        public decimal CalculateVolume()
        {
            decimal volume = Width * Length * Height; //Not using CalculateArea * Height to prevent rounding twice.
            const int decimalPlaces = 3;
            volume = Math.Round(volume, decimalPlaces);
            return volume;
        }
    }
}