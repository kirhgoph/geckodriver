using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    public class MathHelper
    {
        public static double ComputeTriangleArea(double firstSide, double secondSide, double thirdSide)
        {
            ValidateSide(firstSide);
            ValidateSide(secondSide);
            ValidateSide(thirdSide);
            var sides = new double[3];
            sides[0] = firstSide;
            sides[1] = secondSide;
            sides[2] = thirdSide;
            return CalculateTriangleArea(sides);
        }

        public static double ComputeTriangleArea(ICollection<double> sides)
        {
            foreach (var side in sides)
            {
                ValidateSide(side);
            }
            return CalculateTriangleArea(sides);
        }

        private static double CalculateTriangleArea(ICollection<double> sides)
        {
            var sidesArray = sides.ToArray();
            Array.Sort(sidesArray);
            CheckIfTriangleIsRight(sidesArray);
            return sidesArray[0] * sidesArray[1] / 2;
        }

        private static void CheckIfTriangleIsRight(double[] data)
        {
            if (Math.Pow(data[2], 2) != Math.Pow(data[1], 2) + Math.Pow(data[0], 2))
            {
                throw new Exception("Given triangle is not right!");
            };
        }

        private static void ValidateSide(double side)
        {
            if (side <= 0) throw new Exception("Length of a side can not be less than zero!");
        }
    }
}
