using EntityFrameWorkDemo.Contexts;
using EntityFrameWorkDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkDemo.Services
{
    public class UserService : IUserService
    {
        private readonly QRoasterDbContext roasterDbContext;

        public UserService(QRoasterDbContext roasterDbContext)
        {
            this.roasterDbContext = roasterDbContext;
        }

        public List<User> Users()
        {
            return this.roasterDbContext.Users.ToList();
        }
    }
}
