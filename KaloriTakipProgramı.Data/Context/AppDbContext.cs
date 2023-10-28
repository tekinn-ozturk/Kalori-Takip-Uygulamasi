using KaloriTakipProgramı.Data.Extensions;
using KaloriTakipProgramı.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Data.Context
{
	public class AppDbContext : DbContext
	{
		public DbSet<AppUser> AppUsers { get; set; }
		public DbSet<Food> Foods { get; set; }
		public DbSet<ConsumeFood> ConsumeFoods { get; set; }
		public DbSet<Meal> Meals { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Water> Waters { get; set; }
		public DbSet<AppRole> AppRoles { get; set; }
		public DbSet<MacroFoodReport> MacroFoodReports { get; set; }



		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=DESKTOP-TPVT3F8; Database=KaloriTakipDB; Uid=sa; Pwd=123;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.SeedData();
			base.OnModelCreating(modelBuilder);
		}
	}
}
