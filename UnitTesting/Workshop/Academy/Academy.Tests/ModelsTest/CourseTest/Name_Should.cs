using System;
using Academy.Models;
using NUnit.Framework;

namespace Academy.Tests
{
    public class Name_Should
    {
        [Test]
        public void ThrowWhenPassedValueIsInvalid()
        {
            // Arrange
            var dateStarting = new DateTime(2017, 1, 25);
            var dateEnding = new DateTime(2017, 2, 16);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Course("Un", 2, dateStarting, dateEnding));
        }

        [Test]
        public void ThrowWhenPassedValueIsValid()
        {
            // Arrange
            var dateStarting = new DateTime(2017, 1, 25);
            var dateEnding = new DateTime(2017, 2, 16);
            string name = "UnitTesting";
            int lecturesPerWeek = 2;

            // Act & Assert
            Assert.DoesNotThrow(() => new Course(name, lecturesPerWeek, dateStarting, dateEnding));
        }

        [TestCase("UnitTesting")]
        [TestCase("Uni")]
        [TestCase("UnitTestinggggggggggUnitTestingggggggggg55555")]
        [TestCase("JavaScriptOOP")]
        [Test]
        public void CorrectlyAssignPassedValue(string expectedName)
        {
            // Arrange
            var dateStarting = new DateTime(2017, 1, 25);
            var dateEnding = new DateTime(2017, 2, 16);
            string name = expectedName;
            int lecturesPerWeek = 2;

            // Act
            var course = new Course(name, lecturesPerWeek, dateStarting, dateEnding);

            // Assert
            Assert.That(course.Name == expectedName);
        }
    }
}
