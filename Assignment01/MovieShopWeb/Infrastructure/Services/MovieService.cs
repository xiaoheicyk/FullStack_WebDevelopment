using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<int> AddMovieAsync(Movie movie)
        {
            return await _movieRepository.AddAsync(movie);
        }

        public async Task<int> DeleteMovieAsync(int id)
        {
            return await _movieRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
        {
            return await _movieRepository.GetAllAsync();
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            return await _movieRepository.GetMovieById(id);
        }

        public async Task<IEnumerable<Movie>> GetTopRevenueMoviesAsync(int number)
        {
            return await _movieRepository.GetTopRevenueMovies(number);
        }
    }
}