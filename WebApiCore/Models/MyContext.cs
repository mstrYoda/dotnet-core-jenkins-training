using System;
using Microsoft.EntityFrameworkCore;

namespace WebApiCore.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
        :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

        public DbSet<User> Users { get; set; }
    }
}
