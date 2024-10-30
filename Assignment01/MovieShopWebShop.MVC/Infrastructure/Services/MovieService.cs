using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Infrastructure.Repositories;

namespace Infrastructure.Services;

public class MovieService:IMovieService
{
    private readonly MovieShopDbContext _context;

    public MovieService(MovieShopDbContext context)
    {
        _context = context;
    }
    
    

    public Task<Movie> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerator<Movie>> GetTopRevenueAsync(int number = 20)
    {
        throw new NotImplementedException();
    }
}