namespace TriangleAreaTests
{
    [TestClass]
    public class TriangleAreaTests
    {
        [TestMethod]
        [DataRow("Triangle", 1.0D, 1.0D, 1.0D, 0.43D)]
        [DataRow("Triangle", 3.0D, 4.0D, 5.0D, 6.0D)]
        [DataRow("Triangle", 5.0D, 8.0D, 10.0D, 19.81D)]
        public void Area_TriangleSides_ReturnsTriangleArea(string shapeName, double sideA, double sideB, double sideC, double expected)
        {
            Triangle triangle = new(shapeName, sideA, sideB, sideC);

            double actual = triangle.Area();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("Triangle", 3.0D, 4.0D, 5.0D, true)]
        [DataRow("Triangle", 6.0D, 8.0D, 10.0D, true)]
        [DataRow("Triangle", 5.0D, 8.0D, 10.0D, false)]
        [DataRow("Triangle", 6.0D, 10.0D, 12.0D, false)]
        public void IsRightTriangle_TriangleSides_ReturnsIsRight(string shapeName, double sideA, double sideB, double sideC, bool expected)
        {
            Triangle triangle = new(shapeName, sideA, sideB, sideC);

            bool actual = triangle.IsRightTriangle();

            Assert.AreEqual(expected, actual);
        }
    }
}
