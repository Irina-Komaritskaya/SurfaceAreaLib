using FluentAssertions;
using SurfaceAreaLib;
using System;
using Xunit;

namespace SurfaceArea.Tests
{
    public class CircleTests
    {
        [Fact]
        public void Should_Calc_SurfaceArea()
        {
            var circle = new Circle(5);
            var surfaceArea = circle.CalcSurfaceArea();
            surfaceArea.Should().BeGreaterThan(0);
        }

        [Fact]
        public void Should_Calc_SurfaceArea_Exactly()
        {
            var circle = new Circle(1);
            var surfaceArea = circle.CalcSurfaceArea();
            surfaceArea.Should().Be(Math.PI*2);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(double.NaN)]
        public void Should_Throw_ArgumentException_When_Radius_Incorrect(double incorrect)
        {
            var action = () => new Circle(incorrect);
            action.Should().Throw<ArgumentException>();
        }
    }
}