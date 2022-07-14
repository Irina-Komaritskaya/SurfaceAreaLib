using FluentAssertions;
using SurfaceAreaLib;
using System;
using Xunit;

namespace SurfaceArea.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void Should_Calc_SurfaceArea()
        {
            var triangle = new Triangle(5,4,6);
            var surfaceArea = triangle.CalcSurfaceArea();
            surfaceArea.Should().BeGreaterThan(0);
        }

        [Fact]
        public void Should_Calc_SurfaceArea_Exactly()
        {
            var triangle = new Triangle(3,5,7);
            var surfaceArea = triangle.CalcSurfaceArea();
            Math.Round(surfaceArea, 2).Should().Be(6.50);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(double.NaN)]
        public void Should_Throw_ArgumentException_When_Sides_Incorrect(double incorrect)
        {
            var action = () => new Triangle(incorrect, 1,1);
            action.Should().Throw<ArgumentException>();

            action = () => new Triangle(1, incorrect, 1);
            action.Should().Throw<ArgumentException>();

            action = () => new Triangle(1, 1, incorrect);
            action.Should().Throw<ArgumentException>();
        }


        [Fact]
        public void Should_Throw_ArgumentException_Exsist()
        {
            var action = () => new Triangle(8, 1, 1);
            action.Should().Throw<ArgumentException>();
        }

        [Fact]
        public void Should_Triangle_Right()
        {
            var triangle = new Triangle(5, 3, 4);
            triangle.IsRightTriangle().Should().BeTrue();
        }

        [Fact]
        public void Should_Triangle_Not_Right()
        {
            var triangle = new Triangle(1, 1, 1);
            triangle.IsRightTriangle().Should().BeFalse();
        }
    }
}