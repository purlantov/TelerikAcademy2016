using System;
using Academy.Core.Factories;
using Academy.Models.Utils.LectureResources;
using NUnit.Framework;

namespace Academy.Tests
{
    [TestFixture]
    public class CreateLectureResource_Should
    {
        [Test]
        public void ReturnVideoResource_WhenVideoTypeIsPassed()
        {
            // Arrange
            var factory = AcademyFactory.Instance;

            // Act
            var resource = factory.CreateLectureResource("video", "valid name", "url url url url");

            // Assert
            Assert.IsInstanceOf<VideoResource>(resource);
        }

        [Test]
        public void ThrowArgumentExceptionWhenPassedTypeIsInvalid()
        {
            // Arrange
            var factory = AcademyFactory.Instance;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => factory.CreateLectureResource("video", "valid name", "url"));
        }

        [Test]
        public void ReturnCorrectInstancesWithCorrectlyAssignedData()
        {
            // Arrange
            var factory = AcademyFactory.Instance;

            // Act
            var resource = factory.CreateLectureResource("homework", "valid name", "url url url url");

            // Assert
            Assert.IsInstanceOf<HomeworkResource>(resource);
        }
    }
}
