using ApplicationCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
    public interface IMovieService
    {
        Task<int> AddMovieAsync(Movie movie);
        Task<int> DeleteMovieAsync(int id);
        Task<int> UpdateMovieAsync(Movie movie,int Id);
        Task<IEnumerable<Movie>> GetAllMoviesAsync();
        Task<Movie> GetMovieByIdAsync(int id);
        Task<Movie> GetMovieDetailsAsync(int id);
        Task<IEnumerable<Movie>> GetTopRevenueMoviesAsync(int number);
        
    }
}