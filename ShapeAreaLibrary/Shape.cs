namespace ShapeAreaLibrary
{
    /// <summary>Represent an abstract shape.</summary>
    public abstract class Shape
    {
        public string ShapeName { get; set; }

        /// <summary>Initializes a new instance of the <see cref="Shape" /> class.</summary>
        /// <param name="shapeName">Name of the shape.</param>
        public Shape(string shapeName)
        {
            ShapeName = shapeName;
        }

        /// <summary>Calculate the area of a shape.</summary>
        /// <returns>Area of a shape.</returns>
        public abstract double Area();

        /// <summary>Show the selected shape.</summary>
        /// <returns>A string that show selected shape.</returns>
        public override string ToString()
        {
            return $"Selected shape is: " + ShapeName;
        }
    }
}

