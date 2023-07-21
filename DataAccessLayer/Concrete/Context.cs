using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;

namespace DataAccessLayer.Concrete
{
    public class Context: DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-TDIR7IV\\SQLEXPRESS;database=CoreBlogDb2; integrated security=true; ;TrustServerCertificate=true");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get;set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }

        public DbSet<NewsLetter>  NewsLetters { get; set; }
    }
}
