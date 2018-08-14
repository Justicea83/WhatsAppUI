using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WhatUI.Models
{
    public class Repository : DbContext
    {
        public Repository(string path) :base()
        {
            _dbPath = path;
            Database.EnsureCreated();
        }

        string _dbPath;
        public DbSet<Message> Messages { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"FileName={_dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>()
                .HasKey(m => m.Id);
        }
    }
}
