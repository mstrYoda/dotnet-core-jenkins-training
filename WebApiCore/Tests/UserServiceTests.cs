using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit.Sdk;

namespace WebApiCore.Services
{
    public class UserServiceTests
    {
        private Mock<DbContext> _mockedContext;
        
        public void Setup()
        {
            _mockedContext = new Mock<DbContext>();
        }

        

    }
}