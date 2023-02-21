using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using QRoaster.Infrastructure.DBContext;
using QRoaster.Infrastructure.Entities;

namespace QRoaster.Infrastructure.UnitTest
{
    internal class GenericTest
    {
        private ApplicationDbContext _applicationDbContext;
        protected IRepository<User> _userRepository { set; get; }

        [SetUp]
        public void Setup()
        {
            const string connectionString = @"server=172.27.84.156;port=3306;database=qtime;user=qbill_dev;password=Qt@DeV";
            ServerVersion serverVersion = ServerVersion.AutoDetect(connectionString);

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .LogTo(Console.Write, LogLevel.Debug)
                .UseMySql(connectionString, serverVersion)
                .Options;

            _applicationDbContext = new ApplicationDbContext(options);
            _userRepository = new Repository<User>(_applicationDbContext);
        }

        [TearDown]
        public void TearDown()
        {
            _applicationDbContext.Dispose();
        }
    }
}
