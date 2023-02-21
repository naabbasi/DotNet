using CloudCustomers.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace CloudCustomers.API.DBContext
{
    public class UserDBContext : DbContext
    {
        private const string connectionString = "server=172.27.84.156;port=3306;database=qbill;user=qbill_dev;password=Qt@DeV";
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public UserDBContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(connectionString);
        }
    }
}
