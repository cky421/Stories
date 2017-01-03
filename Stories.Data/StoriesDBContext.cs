using Microsoft.EntityFrameworkCore;
using Stories.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stories.Data
{
    public class StoriesDBContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"Server=localhost;database=StoriesDB;uid=root;pwd=19931101;");
    }
}
