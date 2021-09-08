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
            var input = 1992;

            var output = Program.isLeapYear(input);

            Assert.True(output);
        }

        [Fact]
        public void isLeapYear_False_input13()
        {
            var input = 1993;

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

        [Fact]
        public void userInput_printYay_input1996()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("1996");
            Console.SetIn(input);

            // Act
            Program.userInputValidator();

            // Assert
            string[] output = writer.GetStringBuilder().ToString().Split(Environment.NewLine);
            Assert.Equal("yay", output[1].Trim());

            var isLeapYear = Program.isLeapYear(1996);
            Assert.True(isLeapYear);
        }

        [Fact]
        public void userInput_printNay_input2000()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("2000");
            Console.SetIn(input);

            // Act
            Program.userInputValidator();

            // Assert
            string[] output = writer.GetStringBuilder().ToString().Split(Environment.NewLine);
            Assert.Equal("yay", output[1].Trim());

            var isLeapYear = Program.isLeapYear(2000);
            Assert.True(isLeapYear);
        }

        [Fact]
        public void userInput_printNay_input1900()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("1900");
            Console.SetIn(input);

            // Act
            Program.userInputValidator();

            // Assert
            string[] output = writer.GetStringBuilder().ToString().Split(Environment.NewLine);
            Assert.Equal("nay", output[1].Trim());

            var isLeapYear = Program.isLeapYear(1900);
            Assert.False(isLeapYear);
        }

        [Fact]
        public void isLeapYear_Exception_inputString(){
            Assert.Throws<FormatException>(() => Program.isLeapYear(Convert.ToInt32("hello")));
        }

        [Fact]
        public void isLeapYear_Exception_before1582(){
            var input = 1581;

            Assert.Throws<ArgumentOutOfRangeException>(() => Program.isLeapYear(input));
        }

        [Fact]
        public void userInput_Exception_invalidInput(){
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("hello");
            Console.SetIn(input);

            // Act
            Assert.Throws<FormatException>(() => Program.userInputValidator());
        }

        [Fact]
        public void userInput_Exception_before1582(){
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("100");
            Console.SetIn(input);

            // Act
            Assert.Throws<ArgumentOutOfRangeException>(() => Program.userInputValidator());
        }
    }
}
