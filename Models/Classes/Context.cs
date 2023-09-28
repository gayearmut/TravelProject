using Microsoft.EntityFrameworkCore;

namespace TravelProject.Models.Classes
{
	public class Context : DbContext
	{

		public DbSet<Admin> Admins { get; set; }
		public DbSet<AdresBlog> AdresBlogs { get; set; }
		public DbSet<Blog> Blogs { get; set; }
		public DbSet<Hakkimizda> Hakkimizdas { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Comment> Comments { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-OHLH4MB;Database=TravelDb;Trusted_Connection=True");
		}

	}
}
