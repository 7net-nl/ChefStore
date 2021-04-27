using ChefSahar.Domain.Contract.Interfaces;
using ChefSahar.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Infrascture.DataBase.EF
{
    public class AppDbContext : DbContext, IDbContext, IDataSet
    {
       
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.Seed();

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Recipe> Recipe { get; set; }
        public DbSet<Instruction> Instructions { get; set; }
        public DbSet<Ingridient> Ingridients { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
