using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastruture.Data;


public class MovieShopDbContext:DbContext
{
    public MovieShopDbContext(DbContextOptions<MovieShopDbContext> options)
    {
        
    }
    

    public DbSet<Genre> Genres { get; set; }
}