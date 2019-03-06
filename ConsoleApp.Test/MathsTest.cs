using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ConsoleApp.Test
{
    public class MathsTest
    {
        [Fact]
        public void Factorial_WhenPassed5_ShouldReturn120()
        {
            //arrange
            Maths m1 = new Maths();
            //act
            double result = m1.Factorial(5);
            //assert
            Assert.Equal(120,result);
        }

        [Fact]
        public void Fibonacci_ShouldReturnCorrectSequence()
        {
            int[] expected = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            int[] actual = Maths.Fibonacci(10);
            Assert.Equal(expected, actual);
        }
    }
}
