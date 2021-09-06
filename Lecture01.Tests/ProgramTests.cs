using System;
using System.IO;
using Xunit;

namespace Lecture01.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Main_prints_Hello_World()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            // Act
            Program.Main(new string[0]);

            // Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("Hello, World!", output);
        }

        [Fact]
        public void isLeapYear_True_input12()
        {
            var input = 12;

            var output = Program.isLeapYear(input);

            Assert.True(output);
        }

        [Fact]
        public void isLeapYear_False_input13()
        {
            var input = 13;

            var output = Program.isLeapYear(input);

            Assert.False(output);
        }

        [Fact]
        public void isLeapYear_False_input1700()
        {
            var input = 1700;

            var output = Program.isLeapYear(input);

            Assert.False(output);
        }

        [Fact]
        public void isLeapYear_True_input1600()
        {
            var input = 1600;

            var output = Program.isLeapYear(input);

            Assert.True(output);
        }
    }
}
