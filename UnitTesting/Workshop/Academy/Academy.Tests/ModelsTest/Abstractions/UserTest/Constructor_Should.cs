using System;
using Academy.Test;
using NUnit.Framework;

namespace Academy.Tests
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void CorrectlyAssignPassedValue()
        {
            // Arrange
            var user = new UserMock("Pecks");

            // Act
            var givenUserName = user.Username;

            // Assert
            Assert.AreEqual("Pecks", givenUserName);
        }
    }
}
