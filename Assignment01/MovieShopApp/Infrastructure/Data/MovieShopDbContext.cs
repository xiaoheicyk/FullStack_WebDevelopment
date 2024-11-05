using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class MovieShopDbContext:DbContext
{
    public MovieShopDbContext(DbContextOptions<MovieShopDbContext> options):base(options)
    {
        
    }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<MovieGenre> MovieGenres { get; set; }
    
    public DbSet<Cast> Casts { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MovieGenre>()
            .HasKey(mg => new { mg.MovieId, mg.GenreId }); // Setting composite key

        // Optionally configure relationships
        modelBuilder.Entity<MovieGenre>()
            .HasOne(mg => mg.movie)
            .WithMany(m => m.MovieGenres) // Assuming Movie has a collection of MovieGenres
            .HasForeignKey(mg => mg.MovieId);

        modelBuilder.Entity<MovieGenre>()
            .HasOne(mg => mg.genre)
            .WithMany(g => g.MovieGenres) // Assuming Genre has a collection of MovieGenres
            .HasForeignKey(mg => mg.GenreId);
    }
}