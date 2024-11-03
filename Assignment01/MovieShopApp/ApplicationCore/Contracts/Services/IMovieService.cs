using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Services;

public interface IMovieService
{
    Task<IEnumerable<Movie>> GetTopRevenueAsync(int number=20);
    Task<IEnumerable<Movie>> GetMoviesByGenreAsync(int genreId);

    Task<IEnumerable<Movie>> GetAllMoviesAsync();
    
}