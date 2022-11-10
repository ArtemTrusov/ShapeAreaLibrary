namespace CircleAreaTests
{
    [TestClass]
    public class CircleAreaTests
    {
        [TestMethod]
        [DataRow("Circle", 1.0D, 3.14D)]
        [DataRow("Circle", 2.0D, 12.57D)]
        [DataRow("Circle", 4.0D, 50.27D)]
        public void Area_Radius_ReturnsCircleArea(string shapeName, double radius, double expected)
        {
            Circle circle = new(shapeName, radius);

            double actual = circle.Area();

            Assert.AreEqual(expected, actual);
        }
    }
}