namespace ShapeAreaLibrary.shape
{
    /// <summary>Represents a triangle.</summary>
    public class Triangle : Shape
    {
        public double sideA { get; set; }
        public double sideB { get; set; }
        public double sideC { get; set; }


        /// <summary>Initializes a new instance of the <see cref="Triangle" /> class.</summary>
        /// <param name="shapeName">Name of the shape.</param>
        /// <param name="sideA">The side A.</param>
        /// <param name="sideB">The side B.</param>
        /// <param name="sideC">The side C.</param>
        public Triangle(string shapeName, double sideA, double sideB, double sideC) : base(shapeName)
        {
            if (IsExist(sideA, sideB, sideC))
            {
                this.sideA = sideA;
                this.sideB = sideB;
                this.sideC = sideC;
            }
        }

        /// <summary>Calculates the area of a triangle using the Heron's formula.</summary>
        /// <returns>Area of a triangle.</returns>
        public override double Area()
        {
            double halfPerimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Round(Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC)), 2);
            return area;
        }

        /// <summary>Determines whether is right triangle.</summary>
        /// <returns><c>true</c> if is right triangle; otherwise, <c>false</c>.</returns>
        public bool IsRightTriangle()
        {
            bool isRight = Math.Pow(sideA, 2) == Math.Pow(sideB, 2) + Math.Pow(sideC, 2)
                               || Math.Pow(sideB, 2) == Math.Pow(sideA, 2) + Math.Pow(sideC, 2)
                               || Math.Pow(sideC, 2) == Math.Pow(sideA, 2) + Math.Pow(sideB, 2);
            return isRight;
        }

        private bool IsExist(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentOutOfRangeException(string.Format("At least one of the passed triangle sides ( {0}; {1}; {2} ) " +
                    "is zero or negative number", sideA, sideB, sideC));
            }

            if (sideA >= sideB + sideC || sideB >= sideA + sideC || sideC >= sideA + sideB)
            {
                throw new ArgumentOutOfRangeException(string.Format("One of the passed triangle sides ( {0}; {1}; {2} ) " +
                    "is the sum of the other two or greater", sideA, sideB, sideC));
            }

            return true;
        }
    }
}
