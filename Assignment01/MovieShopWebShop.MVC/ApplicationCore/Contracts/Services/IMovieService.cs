using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Services;

public interface IMovieService
{
    Task<IEnumerator<Movie>> GetAllAsync();
    
    Task<Movie> GetByIdAsync(int id);
    
    Task<IEnumerator<Movie>> GetTopRevenueAsync(int number=20);
    
    
}