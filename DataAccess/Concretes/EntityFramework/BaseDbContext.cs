using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    //veritabanını temsil eden dosya
    public class BaseDbContext : DbContext
    {
        public DbSet<Product> Products {  get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-0AI6GGL\\SQLEXPRESS;Initial Catalog=Tobeto4A;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Product>().HasOne(i => i.Category);
            modelBuilder.Entity<Product>().Property(i => i.Name).HasColumnName("Name").HasMaxLength(50);
            
            //Seed Data
            Category category = new Category(1,"Giyim");
            Category category2 = new (2, "Elektronik");
            Category category3 = new (3, "Mobilya");

            Product product = new Product(1,"Kazak",500,50,1);
            Product product2 = new (2, "Telefon", 50000, 50, 2);
            Product product3 = new (3, "Masa", 1500, 20, 3);

            modelBuilder.Entity<Category>().HasData(category, category2,category3);
            modelBuilder.Entity<Product>().HasData(product, product2, product3);

            base.OnModelCreating(modelBuilder);
        }
    }
}