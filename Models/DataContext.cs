using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using MySql.Data.MySqlClient;
using Microsoft.EntityFrameworkCore;


namespace book.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Book> Books { get;set; }

        public DbSet<Author> Authors { get;set; }

        public DbSet<BookMeta> BookMetas { get;set; }

        public DbSet<Publisher> Publishers { get;set; }

        public DbSet<Category> Categories { get;set; }

        // public DbSet<BookCategory> BookCategories { get; set; }

        public DbSet<User> Users { get;set; }

        public DbSet<Rating> Ratings { get;set; }
        public DbSet<CartItem> CartItem { get;set; }
        public DbSet<Order> Orders { get;set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("book");
            modelBuilder.Entity<Book>()
                .HasOne(a => a.BookMeta)
                .WithOne(b => b.Book)
                .HasForeignKey<BookMeta>(b => b.BookId);

            modelBuilder.Entity<Author>().ToTable("author");

            modelBuilder.Entity<BookMeta>().ToTable("book_meta");
            modelBuilder.Entity<BookMeta>().HasOne(d => d.Book)
                .WithOne(c => c.BookMeta);
            modelBuilder.Entity<BookMeta>().HasOne(bm => bm.Publisher)
                .WithMany(p => p.BookMetas);

            modelBuilder.Entity<Publisher>().ToTable("publisher");
            modelBuilder.Entity<Publisher>().HasMany(p => p.BookMetas)
                .WithOne(p => p.Publisher);

            modelBuilder.Entity<User>().ToTable("user");
            modelBuilder.Entity<Rating>().ToTable("rating");
            modelBuilder.Entity<Category>().ToTable("category");

            // modelBuilder.Entity<BookCategory>()
            //     .HasKey(bc => new { bc.BookId, bc.CategoryId });  
            // modelBuilder.Entity<BookCategory>()
            //     .HasOne(bc => bc.Book)
            //     .WithMany(b => b.BookCategories)
            //     .HasForeignKey(bc => bc.BookId);  
            // modelBuilder.Entity<BookCategory>()
            //     .HasOne(bc => bc.Category)
            //     .WithMany(c => c.BookCategories)
            //     .HasForeignKey(bc => bc.CategoryId);
            }

    }
}
