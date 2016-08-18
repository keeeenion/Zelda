namespace Zelda.Models {
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class WebsiteDbContext : DbContext {
		public WebsiteDbContext()
			: base("name=WebsiteDbContext") {
		}

		public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
		public virtual DbSet<User> User { get; set; }
		public virtual DbSet<Website> Website { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder) {
		}
	}
}
