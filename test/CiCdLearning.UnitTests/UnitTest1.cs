using System;
using Xunit;
using CiCdLearning.Controllers;

namespace CiCdLearning.UnitTests
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController(null);

        [Fact]
        public void CallWeatherForecast()
        {
            var results = controller.Get();
            Assert.NotEmpty(results);
        }


        [Fact]
        public void Test1()
        {

        }
    }
}
