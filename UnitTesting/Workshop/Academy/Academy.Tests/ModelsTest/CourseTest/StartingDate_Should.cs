using System;
using Academy.Models;
using NUnit.Framework;

namespace Academy.Tests
{
    public class StartingDate_Should
    {
        [Test]
        public void ThrowNullWhenPassedValueIsInvalid()
        {
            // Arrange
            DateTime? dateStart = null;
            var dateEnding = new DateTime(2017, 2, 16);
            string name = "UnitTesting";
            int lecturesPerWeek = 2;

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => new Course(name, lecturesPerWeek, dateStart, dateEnding));
        }
    }
}
