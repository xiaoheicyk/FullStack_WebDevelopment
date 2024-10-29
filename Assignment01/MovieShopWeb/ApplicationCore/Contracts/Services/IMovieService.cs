using ApplicationCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
    public interface IMovieService
    {
        Task<int> AddMovieAsync(Movie movie);
        Task<int> DeleteMovieAsync(int id);
        Task<IEnumerable<Movie>> GetAllMoviesAsync();
        Task<Movie> GetMovieByIdAsync(int id);
        Task<IEnumerable<Movie>> GetTopRevenueMoviesAsync(int number); // New method for top revenue movies
    }
}