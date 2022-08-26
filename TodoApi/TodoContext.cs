using Microsoft.EntityFrameworkCore;
using System;
using TodoApi.Model;

namespace TodoApi
{
    public class TodoContext : DbContext
    {
        public DbSet<Todo> Todo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TodoAppDB;Trusted_Connection=true;");
        }
    }
}