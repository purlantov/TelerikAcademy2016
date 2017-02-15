using Academy.Models;
using Academy.Models.Contracts;
using Academy.Models.Enums;
using Moq;
using NUnit.Framework;

namespace Academy.Tests
{
    [TestFixture]
    public class ListCourses_Should
    {
        [Test]
        public void ReturnListOfCourses()
        {
            // Arrange
            int starting = 2016;
            int ending = 2017;
            Initiative initiative = Initiative.SchoolAcademy;
            var season = new Season(starting, ending, initiative);
            var courseMock = new Mock<ICourse>();
            courseMock.Setup(x => x.ToString());

            // Act
            season.Courses.Add(courseMock.Object);
            season.ListCourses();

            // Assert
            courseMock.Verify(x => x.ToString(), Times.Once);
        }

        [Test]
        public void ReturnMessageSayingThatThereAreNoCoursesInThisSeason()
        {
            // Arrange
            int starting = 2016;
            int ending = 2017;
            Initiative initiative = Initiative.SchoolAcademy;
            var season = new Season(starting, ending, initiative);

            // Act
            var result = season.ListCourses();

            // Assert
            StringAssert.Contains("no courses", result);
        }
    }
}
