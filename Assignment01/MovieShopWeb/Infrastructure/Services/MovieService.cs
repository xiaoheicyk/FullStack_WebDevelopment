using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Contracts.Services;

namespace Infrastructure.Services
{
    public class MovieService :IMovieService
    {
        private readonly IMovieRepository _repository;

        public MovieService(IMovieRepository repo)
        {
            _repository = repo;
        }


        public Task<int> AddMovieAsync(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteMovieAsync(int id)
        {
            return _repository.DeleteAsync(id);
        }

        public async Task<int> UpdateMovieAsync(Movie movie,int Id)
        {
            if (movie.Id == Id)
            {
                return await _repository.UpdateAsync(movie);
            }

            return 0;
        }

        public Task<IEnumerable<Movie>> GetAllMoviesAsync()
        {
            return _repository.GetAllAsync();
        }

        public Task<Movie> GetMovieByIdAsync(int id)
        {
            return _repository.GetMovieByIdAsync(id);
        }

        public Task<Movie> GetMovieDetailsAsync(int id)
        {
            return _repository.GetMovieByIdAsync(id);
        }

        public Task<IEnumerable<Movie>> GetTopRevenueMoviesAsync(int number)
        {
            return _repository.GetTopRevenueMoviesAsync(number);
        }
    }
}