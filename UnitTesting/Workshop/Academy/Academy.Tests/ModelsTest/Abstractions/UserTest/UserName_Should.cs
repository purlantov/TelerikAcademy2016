using System;
using Academy.Test;
using NUnit.Framework;

namespace Academy.Tests
{
    [TestFixture]
    public class UserName_Should
    {
        [Test]
        public void ThrowArgumentExceptionWhenPassedValueIsInvalid()
        {
            //Act && Assert
            Assert.Throws<ArgumentException>(() => new UserMock("va"));
        }

        [Test]
        public void NotThrowWhenPassedValueIsValid()
        {
            //Act && Assert
            Assert.DoesNotThrow(() => new UserMock("valid"));
        }


    }
}
