using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Infrastruture.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastruture.Repositories;

public class MovieRepository : BaseRepository<Movie>, IMovieRepository
{
    private readonly MovieShopDbContext _context;
    public MovieRepository(MovieShopDbContext c) : base(c)
    {
        _context = c;
    }

    public async Task<IEnumerable<Movie>> GetTopRevenueMovies(int number = 20)
    {
        return await _context.Movies.OrderByDescending(m => m.Revenue).Take(number).ToListAsync();
    }
    
}