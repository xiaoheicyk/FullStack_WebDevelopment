using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Services;

public interface IMovieService
{
    Task<IEnumerable<Movie>> GetTopRevenueAsync(int number=20);
    
}