using System;
using Xunit;
using WebApiCore.Services;
using Moq;
using Xunit.Sdk;
using WebApiCore.Models;

namespace WebApiCore.Tests
{
    public class UserServiceTests
    {
        private Mock<MyContext> _mockedContext;
        
        public void Setup()
        {
            _mockedContext = new Mock<MyContext>();
        }

        [Fact]
        public void ReturnFalseGivenValueOf1()
        {
            var result = false;

            Assert.False(result, $"success");
        }

    }
}
