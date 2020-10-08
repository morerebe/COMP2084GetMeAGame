using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace COMP2084GetMeAGame.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        // reference each model
        public DbSet<Models.Category> Categories { get; set; }
        public DbSet<Models.Product> Products { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
