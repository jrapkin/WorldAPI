
using Microsoft.EntityFrameworkCore;
using WorldAPI.Entities.Models;

namespace WorldAPI.Entities.Data
{
	public partial class WorldDbContext : DbContext
	{
		public WorldDbContext()
		{
		}

		public WorldDbContext(DbContextOptions<WorldDbContext> options)
			: base(options)
		{
		}

		public virtual DbSet<City> Cities { get; set; }
		public virtual DbSet<Country> Countries { get; set; }
		public virtual DbSet<State> States { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseMySql("MySqlConnection", x => x.ServerVersion("8.0.20-mysql"));
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<City>(entity =>
			{
				entity.HasKey(c => c.Id)
					  .HasName("PrimaryKey_Id");
				entity.HasOne(c => c.State)
					  .WithMany(s => s.Cities)
					  .HasForeignKey(s => s.StateId);


				entity.ToTable("cities");

				entity.Property(e => e.CountryCode)
					.HasColumnName("country_code")
					.HasColumnType("text")
					.HasCharSet("utf8mb4")
					.HasCollation("utf8mb4_0900_ai_ci");

				entity.Property(e => e.CountryId)
					  .HasColumnName("country_id");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Latitude).HasColumnName("latitude");

				entity.Property(e => e.Longitude).HasColumnName("longitude");

				entity.Property(e => e.Name)
					.HasColumnName("name")
					.HasColumnType("text")
					.HasCharSet("utf8mb4")
					.HasCollation("utf8mb4_0900_ai_ci");

				entity.Property(e => e.StateCode)
					.HasColumnName("state_code")
					.HasColumnType("text")
					.HasCharSet("utf8mb4")
					.HasCollation("utf8mb4_0900_ai_ci");

				entity.Property(e => e.StateId).HasColumnName("state_id");
			});

			modelBuilder.Entity<Country>(entity =>
			{
				entity.HasKey(c => c.Id)
					  .HasName("PrimaryKey_Id");

				entity.ToTable("countries");

				entity.Property(e => e.Capital)
					.HasColumnName("capital")
					.HasColumnType("text")
					.HasCharSet("utf8mb4")
					.HasCollation("utf8mb4_0900_ai_ci");

				entity.Property(e => e.Currency)
					.HasColumnName("currency")
					.HasColumnType("text")
					.HasCharSet("utf8mb4")
					.HasCollation("utf8mb4_0900_ai_ci");

				entity.Property(e => e.Emoji)
					.HasColumnName("emoji")
					.HasColumnType("text")
					.HasCharSet("utf8mb4")
					.HasCollation("utf8mb4_0900_ai_ci");

				entity.Property(e => e.EmojiU)
					.HasColumnName("emojiU")
					.HasColumnType("text")
					.HasCharSet("utf8mb4")
					.HasCollation("utf8mb4_0900_ai_ci");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Iso2)
					.HasColumnName("iso2")
					.HasColumnType("text")
					.HasCharSet("utf8mb4")
					.HasCollation("utf8mb4_0900_ai_ci");

				entity.Property(e => e.Iso3)
					.HasColumnName("iso3")
					.HasColumnType("text")
					.HasCharSet("utf8mb4")
					.HasCollation("utf8mb4_0900_ai_ci");

				entity.Property(e => e.Name)
					.HasColumnName("name")
					.HasColumnType("text")
					.HasCharSet("utf8mb4")
					.HasCollation("utf8mb4_0900_ai_ci");

				entity.Property(e => e.Native)
					.HasColumnName("native")
					.HasColumnType("text")
					.HasCharSet("utf8mb4")
					.HasCollation("utf8mb4_0900_ai_ci");

				entity.Property(e => e.PhoneCode)
					.HasColumnName("phone_code")
					.HasColumnType("text")
					.HasCharSet("utf8mb4")
					.HasCollation("utf8mb4_0900_ai_ci");
			});

			modelBuilder.Entity<State>(entity =>
			{
				entity.HasKey(s => s.Id)
					  .HasName("PrimaryKey_Id");

				entity.HasOne(s => s.Country)
					  .WithMany(c => c.States)
					  .HasForeignKey(s => s.CountryId);

				entity.ToTable("states");

				entity.Property(e => e.CountryCode)
					.HasColumnName("country_code")
					.HasColumnType("text")
					.HasCharSet("utf8mb4")
					.HasCollation("utf8mb4_0900_ai_ci");

				entity.Property(e => e.CountryId).HasColumnName("country_id");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Name)
					.HasColumnName("name")
					.HasColumnType("text")
					.HasCharSet("utf8mb4")
					.HasCollation("utf8mb4_0900_ai_ci");

				entity.Property(e => e.StateCode)
					.HasColumnName("state_code")
					.HasColumnType("text")
					.HasCharSet("utf8mb4")
					.HasCollation("utf8mb4_0900_ai_ci");
			});

			OnModelCreatingPartial(modelBuilder);
		}

		partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
	}
}
