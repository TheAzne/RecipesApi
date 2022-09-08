using Microsoft.EntityFrameworkCore;
using RecipesApi.Models;
using System;
using System.Collections.Generic;

namespace RecipesApi.Data
{


    public class RecipesContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Recipe> Recipes  { get; set; }

        //TODO: Connect to database

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer($"Data Source=");
    }


}