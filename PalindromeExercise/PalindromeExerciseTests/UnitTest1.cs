using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("boob", true)]
        [InlineData("mom", true)]
        [InlineData("kayak", true)]
        [InlineData("pink", false)]
        [InlineData("Jessica", false)]

        public void PalindromeTest(string words, bool expected)
        {
            //Arrange
            var wordsmith = new WordSmith();
            //Act
            var act = wordsmith.IsAPalindrome(words);
            //Assert
            Assert.Equal(expected, act);
        }
    }
}