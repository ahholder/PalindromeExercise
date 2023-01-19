using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("wow", true)]
        [InlineData("alex", false)]
        [InlineData("mom", true)]
        [InlineData("great", false)]
        [InlineData("establish", false)]
        [InlineData("anna", true)]
        [InlineData("tot", true)]
        [InlineData("arcane", false)]
        [InlineData("deed", true)]
        public void Test1(string word, bool expected)
        {
            //Arrange
            var smith = new WordSmith();
            //Act
            var actual = smith.IsAPalindrome(word);
            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
