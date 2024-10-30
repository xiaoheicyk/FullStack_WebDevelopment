using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class MovieService:IMovieService
{
    private readonly MovieShopDbContext _context;

    public MovieService(MovieShopDbContext context)
    {
        _context = context;
    }
    
    

    public async Task<IEnumerable<Movie>> GetTopRevenueAsync(int number = 20)
    {
        return await _context.Movies.OrderByDescending(m => m.Revenue).Take(20).ToListAsync();
    }
}