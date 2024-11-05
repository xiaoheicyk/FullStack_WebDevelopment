using ApplicationCore.Entities;
using ApplicationCore.Models.ResponseModels;

namespace ApplicationCore.Contracts.Services;

public interface IMovieService
{
    Task<List<MovieCardResponseModel>> GetTopRevenueAsync(int number = 20);
    Task<IEnumerable<Movie>> GetMoviesByGenreAsync(int genreId);

    Task<IEnumerable<Movie>> GetAllMoviesAsync();
    
    Task<Movie> GetMovieByIdAsync(int id);
    
}