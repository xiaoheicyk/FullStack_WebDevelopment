using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Services;

public interface IMovieService
{
    
    Task<Movie> GetByIdAsync(int id);
    
    Task<IEnumerator<Movie>> GetTopRevenueAsync(int number=20);
    
    
}