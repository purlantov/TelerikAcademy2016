using Academy.Models;
using Academy.Models.Contracts;
using Academy.Models.Enums;
using Moq;
using NUnit.Framework;

namespace Academy.Tests
{
    [TestFixture]
    public class ListUsers_Should
    {
        [Test]
        public void ReturnListOfStudentsAndTreiners()
        {
            // Arrange
            int starting = 2016;
            int ending = 2017;
            Initiative initiative = Initiative.SchoolAcademy;
            var season = new Season(starting, ending, initiative);

            var studentMock = new Mock<IStudent>();
            studentMock.Setup(s => s.Username).Returns("Pavel");
            studentMock.Setup(s => s.ToString());
            var trainerMock = new Mock<ITrainer>();
            trainerMock.Setup(t => t.Username).Returns("Marto");
            trainerMock.Setup(t => t.ToString());

            // Act
            season.Students.Add(studentMock.Object);
            season.Trainers.Add(trainerMock.Object);
            season.ListUsers();
            //var result = season.ListUsers();
            
            // Assert
            trainerMock.Verify(x => x.ToString(), Times.Once);
            //StringAssert.Contains("Marto", result);
        }

        [Test]
        public void ReturnMessageSayingThatThereAreNoUsersInThisSeason()
        {
            // Arrange
            int starting = 2016;
            int ending = 2017;
            Initiative initiative = Initiative.SchoolAcademy;

            // Act
            var season = new Season(starting, ending, initiative);

            // Assert
            StringAssert.Contains("There are no users", season.ListUsers());
        }
    }
}