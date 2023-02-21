using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using QRoaster.Infrastructure.DBContext;
using QRoaster.Infrastructure.Entities;

namespace QRoaster.Infrastructure.UnitTest
{
    /*[TestFixture]*/
    internal class DBContextTest : GenericTest
    {
        [Test, Order(1)]
        public void CheckDBContext()
        {
            var users = _userRepository.List().Result;
            Assert.IsNotEmpty(users);
        }
    }
}