using Lab23_MovieSearchDatabase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lab23_MovieSearchDatabase.Data
{
    public class DB_Context : DbContext
    {
        public DB_Context(DbContextOptions<DB_Context> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>(eb =>
            {
                eb.Property(x => x.Title)
                    .HasMaxLength(50)
                    .IsRequired();
                eb.Property(x => x.Genre)
                    .HasConversion(new EnumToStringConverter<MovieGenre>())
                    .HasMaxLength(20)
                    .IsRequired();
            });
        }
    }
}
