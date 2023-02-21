//Import are defined in Using.cs
namespace TestCases
{
    public class Tests
    {
        private UserDBContext userDBContext;
        private long savedUserGKey;

        [SetUp]
        public void Setup()
        {
           userDBContext = new UserDBContext();
        }

        [Test, Order(1)]
        public void AddTestUser()
        {
            User user = new()
            {
                Username = "test_user",
                Password = "x",
                LanguageGkey = 1
            };

            this.userDBContext.Add(user);
            Task<int> saveStatus = this.userDBContext.SaveChangesAsync();
            Assert.That(actual: 1L, Is.EqualTo(expected: saveStatus.Result));

            savedUserGKey = user.UserGkey;
            Assert.That(actual: 0L, Is.Not.EqualTo(expected: savedUserGKey));
        }

        [Test, Order(2)]
        public void GetSavedUserByGenericKey()
        {            
            User getUser = userDBContext.Users.Find(savedUserGKey);
            Assert.That(getUser.Username, Is.EqualTo("test_user"));
        }

        [Test, Order(3)]
        public void GetSavedUserByUsername()
        {
            User user = new();
            User getUser = userDBContext
                            .Users
                            .Where(user => user.Username == "test_user")
                            .FirstOrDefault();

            Assert.That(getUser.Username, Is.EqualTo("test_user"));
        }

        [Test, Order(4)]
        public void DeleteSavedUserByUsername()
        {
            User user = new User
            {
                UserGkey = savedUserGKey,
                Username = "test_user"
            };
            userDBContext.Users.Remove(user);

            User getUser = userDBContext.Users.Find(savedUserGKey);
            Assert.That(getUser.Username, Is.EqualTo("test_user"));
        }
    }
}