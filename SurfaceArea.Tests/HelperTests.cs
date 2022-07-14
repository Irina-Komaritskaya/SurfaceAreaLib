using FluentAssertions;
using SurfaceAreaLib;
using Xunit;

namespace SurfaceArea.Tests
{
    public class HelperTests
    {

        [Fact]
        public void Should_Calc_SurfaceArea()
        {
            var figure = new Circle(5);
            var surfaceArea = Helpers.CalcSurfaceArea(figure);
            surfaceArea.Should().BeGreaterThan(0);
        }
    }
}
