namespace ShapeAreaLibrary.shape
{
    /// <summary>Represent a circle.</summary>
    public class Circle : Shape
    {
        public double Radius { get; set; }

        /// <summary>Initializes a new instance of the <see cref="Circle" /> class.</summary>
        /// <param name="shapeName">Name of the shape.</param>
        /// <param name="radius">The radius.</param>
        public Circle(string shapeName, double radius) : base(shapeName)
        {
            if (IsExist(radius))
            {
                Radius = radius;
            }
        }

        /// <summary>Calculates the area of a circle ( A = PI * <see cref="Radius"/> ^ 2 ).</summary>
        /// <returns>Area of a circle.</returns>
        public override double Area()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }

        private static bool IsExist(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException(string.Format("Passed radius ( {0} ) " +
                    "is zero or less than zero", radius));
            }
            return true;
        }
    }
}