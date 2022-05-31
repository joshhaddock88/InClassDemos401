using FizzBuzz2022;

namespace FizzBuzzTests
{
    public class UnitTest1
    {
        // This is a "Annotation"
        // Annotations decorate methods 
        // Decoration menas: Adds common functionality
        [Fact] // Truth. It's a boolean.
        public void CanReturnString()
        {
            Assert.Equal("1", FizzBuzz.Convert(1));
        }

        [Fact]
        public void ReturnsFizzForThree()
        {
            Assert.Equal("fizz", FizzBuzz.Convert(3));
        }

        [Fact]
        public void ReturnsBuzzForFive()
        {
            Assert.Equal("buzz", FizzBuzz.Convert(5));
        }

        [Fact]
        public void ReturnsFizzBuzzForFifteen()
        {
            Assert.Equal("fizzbuzz", FizzBuzz.Convert(15));
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "fizz")]
        [InlineData(4, "4")]
        [InlineData(5, "buzz")]
        [InlineData(6, "fizz")]
        [InlineData(7, "7")]
        [InlineData(15, "fizzbuzz")]
        public void CheckAllTheNumbers( int input, string expectedOutput )
        {
            Assert.Equal(expectedOutput, FizzBuzz.Convert(input));
        }
    }
}