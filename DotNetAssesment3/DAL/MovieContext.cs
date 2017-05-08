using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotNetAssesment3.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DotNetAssesment3.DAL
{
    public class MovieContext:DbContext
    {
        public MovieContext() : base("name=MyConnectionString")
            { 
            }
        
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderRow> OrderRows { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}