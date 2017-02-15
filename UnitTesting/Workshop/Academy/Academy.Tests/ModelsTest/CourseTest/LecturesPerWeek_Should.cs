using System;
using Academy.Models;
using NUnit.Framework;

namespace Academy.Tests
{
    public class LecturesPerWeek_Should
    {
        [TestCase(0)]
        [TestCase(8)]
        [TestCase(112097409)]
        [Test]
        public void LecturesPerWeek_ShouldThrowWhenPassedValueIsInvalid(int lectures)
        {
            // Arrange
            var dateStarting = new DateTime(2017, 1, 25);
            var dateEnding = new DateTime(2017, 2, 16);
            string name = "UnitTesting";
            int lecturesPerWeek = lectures;

            //Arrange
            Assert.Throws<ArgumentException>(() => new Course(name, lecturesPerWeek, dateStarting, dateEnding));
        }

        [Test]
        public void LecturesPerWeek_ShouldNotThrowWhenThePassedValueIsValid()
        {
            // Arrange
            var dateStarting = new DateTime(2017, 1, 25);
            var dateEnding = new DateTime(2017, 2, 16);
            string name = "UnitTesting";
            int lecturesPerWeek = 6;

            // Act & Assert
            Assert.DoesNotThrow(() => new Course(name, lecturesPerWeek, dateStarting, dateEnding));
        }

        [TestCase(1)]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(7)]
        [Test]
        public void LecturesPerWeek_ShouldCorrectlyAssignPassedValue(int lectures)
        {
            // Arrange
            var dateStarting = new DateTime(2017, 1, 25);
            var dateEnding = new DateTime(2017, 2, 16);
            string name = "UnitTesting";
            int lecturesPerWeek = lectures;

            // Act
            var course = new Course(name, lecturesPerWeek, dateStarting, dateEnding);

            //Arrange
            Assert.That(() => course.LecturesPerWeek == lectures);
        }
    }
}
