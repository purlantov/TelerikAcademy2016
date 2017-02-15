using System;
using NUnit.Framework;
using Moq;
using Academy.Models;
using Academy.Models.Contracts;

namespace Academy.Tests
{
    [TestFixture]
    public class ConstructorShould
    {
        [Test]
        public void CorrectlyAssignPassedValues()
        {
            // Arrange
            var dateStarting = new DateTime(2017, 1, 25);
            var dateEnding = new DateTime(2017, 2, 16);
            string name = "UnitTesting";
            int lecturesPerWeek = 2;

            // Act
            var course = new Course(name, lecturesPerWeek, dateStarting, dateEnding);

            // Assert
            Assert.IsInstanceOf<Course>(course);
        }

        [Test]
        public void CorrectlyInitializeTheCollections()
        {
            // Arrange
            var dateStarting = new DateTime(2017, 1, 25);
            var dateEnding = new DateTime(2017, 2, 16);
            string name = "UnitTesting";
            int lecturesPerWeek = 2;

            // Act
            var course = new Course(name, lecturesPerWeek, dateStarting, dateEnding);

            // Assert
            //CollectionAssert.AllItemsAreInstancesOfType(course.OnlineStudents, typeof(IStudent));
            //CollectionAssert.AllItemsAreInstancesOfType(course.OnlineStudents, typeof(List<IStudent>));
            CollectionAssert.AllItemsAreInstancesOfType(course.OnlineStudents, typeof(ITrainer));
        }


    }
}
