using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Infrastructure.Models;
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
        return await _context.Movies.OrderByDescending(m => m.Revenue).Take(number).ToListAsync();
    }
    
    public async Task<PaginatedList<Movie>> GetPaginatedMoviesAsync(int pageIndex, int pageSize)
    {
        var movies = await _context.Movies
            .OrderBy(m => m.Title) 
            .Skip((pageIndex - 1) * pageSize) 
            .Take(pageSize)
            .ToListAsync();
        
        var totalCount = await _context.Movies.CountAsync();
        
        return new PaginatedList<Movie>(movies, totalCount, pageIndex, pageSize);
    }
}