
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

				entity.HasIndex(e => e.StateId)
					  .HasName("fk_State_Id_idx");

				entity.HasOne(c => c.State)
					  .WithMany(s => s.Cities)
					  .HasForeignKey(s => s.StateId)
					  .HasConstraintName("fk_State_Id");


				entity.ToTable("cities");

				entity.Property(e => e.CountryCode)
					.HasColumnName("country_code")
					.HasColumnType("text")
					.HasCharSet("utf8mb4")
					.HasCollation("utf8mb4_0900_ai_ci");

				entity.Property(e => e.CountryId)
					  .HasColumnName("Country_Id");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Latitude).HasColumnName("Latitude");

				entity.Property(e => e.Longitude).HasColumnName("Longitude");

				entity.Property(e => e.Name)
					.HasColumnName("Name")
					.HasColumnType("text")
					.HasCharSet("utf8mb4")
					.HasCollation("utf8mb4_0900_ai_ci");

				entity.Property(e => e.StateCode)
					.HasColumnName("State_Code")
					.HasColumnType("text")
					.HasCharSet("utf8mb4")
					.HasCollation("utf8mb4_0900_ai_ci");

				entity.Property(e => e.StateId).HasColumnName("State_Id");
			});

			modelBuilder.Entity<Country>(entity =>
			{
				entity.HasKey(c => c.Id)
					  .HasName("PrimaryKey_Id");

				entity.ToTable("countries");

				entity.Property(e => e.Capital)
					.HasColumnName("Capital")
					.HasColumnType("text")
					.HasCharSet("utf8mb4")
					.HasCollation("utf8mb4_0900_ai_ci");

				entity.Property(e => e.Currency)
					.HasColumnName("Currency")
					.HasColumnType("text")
					.HasCharSet("utf8mb4")
					.HasCollation("utf8mb4_0900_ai_ci");

				entity.Property(e => e.Emoji)
					.HasColumnName("Emoji")
					.HasColumnType("text")
					.HasCharSet("utf8mb4")
					.HasCollation("utf8mb4_0900_ai_ci");

				entity.Property(e => e.EmojiU)
					.HasColumnName("EmojiU")
					.HasColumnType("text")
					.HasCharSet("utf8mb4")
					.HasCollation("utf8mb4_0900_ai_ci");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Iso2)
					.HasColumnName("Iso2")
					.HasColumnType("text")
					.HasCharSet("utf8mb4")
					.HasCollation("utf8mb4_0900_ai_ci");

				entity.Property(e => e.Iso3)
					.HasColumnName("Iso3")
					.HasColumnType("text")
					.HasCharSet("utf8mb4")
					.HasCollation("utf8mb4_0900_ai_ci");

				entity.Property(e => e.Name)
					.HasColumnName("Name")
					.HasColumnType("text")
					.HasCharSet("utf8mb4")
					.HasCollation("utf8mb4_0900_ai_ci");

				entity.Property(e => e.Native)
					.HasColumnName("Native")
					.HasColumnType("text")
					.HasCharSet("utf8mb4")
					.HasCollation("utf8mb4_0900_ai_ci");

				entity.Property(e => e.PhoneCode)
					.HasColumnName("Phone_Code")
					.HasColumnType("text")
					.HasCharSet("utf8mb4")
					.HasCollation("utf8mb4_0900_ai_ci");
			});

			modelBuilder.Entity<State>(entity =>
			{
				entity.HasKey(s => s.Id)
					  .HasName("PrimaryKey_Id");

				entity.HasIndex(e => e.CountryId)
					  .HasName("fk_CountryId_idx");

				entity.HasOne(s => s.Country)
					  .WithMany(c => c.States)
					  .HasForeignKey(s => s.CountryId)
					  .HasConstraintName("fk_CountryId");

				entity.ToTable("states");

				entity.Property(e => e.CountryCode)
					.HasColumnName("Country_Code")
					.HasColumnType("text")
					.HasCharSet("utf8mb4")
					.HasCollation("utf8mb4_0900_ai_ci");

				entity.Property(e => e.CountryId).HasColumnName("Country_Id");

				entity.Property(e => e.Id).HasColumnName("Id");

				entity.Property(e => e.Name)
					.HasColumnName("Name")
					.HasColumnType("text")
					.HasCharSet("utf8mb4")
					.HasCollation("utf8mb4_0900_ai_ci");

				entity.Property(e => e.StateCode)
					.HasColumnName("State_Code")
					.HasColumnType("text")
					.HasCharSet("utf8mb4")
					.HasCollation("utf8mb4_0900_ai_ci");
			});

			OnModelCreatingPartial(modelBuilder);
		}

		partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
	}
}
