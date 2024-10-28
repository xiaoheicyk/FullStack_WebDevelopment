using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastruture.Data;


public class MovieShopDbContext:DbContext
{
    public MovieShopDbContext(DbContextOptions<MovieShopDbContext> options):base(options)
    {
        
    }
    

    //communicate with database
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Cast> Casts { get; set; }
}