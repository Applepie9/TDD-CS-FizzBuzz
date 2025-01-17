using FluentAssertions;
using FizzBuzz;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(7)]
        public void GivenANumberNotDivisibleBy3or5_ThenReturnNumbersAsString(int number)
        {
            var result = FizzBuzzGame.Play(number);

            result.Should().Be(number.ToString());

        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void GivenANumberNotDivisibleBy5_ThenReturnsBuzz(int number)
        {
            var result = FizzBuzzGame.Play(number);

            result.Should().Be("Buzz");
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void GivenANumberNotDivisibleBy3_ThenReturnsFizz(int number)
        {
            var result = FizzBuzzGame.Play(number);

            result.Should().Be("Fizz");
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        public void GivenANumberNotDivisibleBy3and5_ThenReturnsFizzBuzz(int number)
        {
            var result = FizzBuzzGame.Play(number);

            result.Should().Be("FizzBuzz");
        }
    }

}