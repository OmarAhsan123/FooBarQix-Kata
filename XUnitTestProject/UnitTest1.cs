using CodingKataProblem2;
using System;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void IfNotDivisibleOrContains3Or5O7ThenReturnTheSameValue()
        {
            // Arrange
            int input = 22;
            
            // Assert
            Assert.Equal("22", input.Compute());
        }

        [Fact]
        public void IfDivisibleBy3ThenReturnFooFoo()
        {
            // Arrange
            FooBarQix fooBarQix = new FooBarQix(3);
            
            // Assert
            Assert.Equal("FooFoo", fooBarQix.GetFooBarQixResult());
        }

        [Fact]
        public void IfDivisibleBy5ThenReturnBarBar()
        {
            // Arrange
            FooBarQix fooBarQix = new FooBarQix(5);
            
            // Assert
            Assert.Equal("BarBar", fooBarQix.GetFooBarQixResult());
        }

        [Fact]
        public void IfDivisibleBy7ThenReturnQixQix()
        {
            // Arrange
            FooBarQix fooBarQix = new FooBarQix(7);
            
            // Assert
            Assert.Equal("QixQix", fooBarQix.GetFooBarQixResult());
        }

        [Fact]
        public void IfDivisibleBy3And5ThenReturnFooBarBar()
        {
            // Arrange
            FooBarQix fooBarQix = new FooBarQix(15);

            // Assert
            Assert.Equal("FooBarBar", fooBarQix.GetFooBarQixResult());
        }

        [Fact]
        public void IfDivisibleBy3And7ThenReturnFooQix()
        {
            // Arrange
            FooBarQix fooBarQix = new FooBarQix(21);

            // Assert
            Assert.Equal("FooQix", fooBarQix.GetFooBarQixResult());
        }

        [Fact]
        public void IfDivisibleBy5And7ThenReturnFooBarBarQix()
        {
            // Arrange
            FooBarQix fooBarQix = new FooBarQix(35);

            // Assert
            Assert.Equal("BarQixFooBar", fooBarQix.GetFooBarQixResult());
        }

        [Fact]
        public void IfDivisibleBy3And5And7ThenReturnFooBarBarQix()
        {
            // Arrange
            FooBarQix fooBarQix = new FooBarQix(105);

            // Assert
            Assert.Equal("FooBarQix*Bar", fooBarQix.GetFooBarQixResult());
        }
        
        [Fact]
        public void IfDivisibleBy3And5And7AndContains3And5ThenReturnFooBarBarQix()
        {
            // Arrange
            FooBarQix fooBarQix = new FooBarQix(315);

            // Assert
            Assert.Equal("FooBarQixFooBar", fooBarQix.GetFooBarQixResult());
        }

        [Fact]
        public void IfContains0ThenReturnAsterix()
        {
            // Arrange
            FooBarQix fooBarQix = new FooBarQix(0);

            // Assert
            Assert.Equal("*", fooBarQix.GetFooBarQixResult());
        }

        [Fact]
        public void If303ThenReturnFooFooAsterixFoo()
        {
            // Arrange
            FooBarQix fooBarQix = new FooBarQix(303);

            // Assert
            Assert.Equal("FooFoo*Foo", fooBarQix.GetFooBarQixResult());
        }

        [Fact]
        public void If101ThenReturn1Asterix1()
        {
            // Arrange
            FooBarQix fooBarQix = new FooBarQix(101);

            // Assert
            Assert.Equal("1*1", fooBarQix.GetFooBarQixResult());
        }

        [Fact]
        public void If103ThenReturn1AsterixFoo()
        {
            // Arrange
            FooBarQix fooBarQix = new FooBarQix(103);

            // Assert
            Assert.Equal("1*Foo", fooBarQix.GetFooBarQixResult());
        }

    }
}
