using System;
using Academy.Models;
using Academy.Models.Contracts;
using Moq;
using NUnit.Framework;

namespace Academy.Tests
{
    public class ToString_Should
    {

        [Test]
        public void IterateOverLecturesCollection_WhenTheCollectionIsNotEmpty()
        {
            // Arrange
            var dateStarting = new DateTime(2017, 1, 25);
            var dateEnding = new DateTime(2017, 2, 16);
            string name = "UnitTesting";
            int lecturesPerWeek = 2;

            var course = new Course(name, lecturesPerWeek, dateStarting, dateEnding);

            var LectureMock = new Mock<ILecture>();
            LectureMock.Setup(x => x.ToString());
            course.Lectures.Add(LectureMock.Object);

            // Act
            course.ToString();

            // Assert
            LectureMock.Verify(x => x.ToString(), Times.Once);
        }

        [Test]
        public void ReturnPassedDataAndMessage()
        {
            // Arrange
            var dateStarting = new DateTime(2017, 1, 25);
            var dateEnding = new DateTime(2017, 2, 16);
            string name = "UnitTesting";
            int lecturesPerWeek = 2;

            var course = new Course(name, lecturesPerWeek, dateStarting, dateEnding);

            // Act
            var result = course.ToString();

            // Assert
            StringAssert.Contains("are no lectures", result);
        }
    }
}
