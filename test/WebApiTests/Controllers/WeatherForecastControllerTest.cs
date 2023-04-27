// add a namespace for the WeatherForecastController
using WebApi.Controllers;

namespace WebApiTests;



[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
    }

    // add a test method that tests the GetRange method of WeatherForecastContoller
    // Path: test/WebAPITests/Controllers/WeatherForecastControllerTests.cs
    [TestMethod]
    public void GetRangeTest()
    {
        // Arrange
        var controller = new WeatherForecastController(null);

        // Act
        var result = controller.Get();

        // Assert
        Assert.AreEqual(5, result.Count());
    }
}