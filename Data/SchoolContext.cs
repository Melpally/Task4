using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNetIden.RazorPage.Models;

namespace AspNetIden.RazorPage.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext (DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }
		public DbSet<User> Users { get; set; }
		public DbSet<AspNetIden.RazorPage.Models.User> User { get; set; } = default!;
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>().ToTable("User");
		}
	}
}
