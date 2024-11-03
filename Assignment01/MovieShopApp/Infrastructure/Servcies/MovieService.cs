using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;

namespace Infrastructure.Servcies;

public class MovieService:IMovieService
{
    private readonly IMovieRepository _movieRepository;

    public MovieService(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }
    public Task<IEnumerable<Movie>> GetTopRevenueAsync(int number = 20)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Movie>> GetMoviesByGenreAsync(int genreId)
    {
        return _movieRepository.GetMoviesByGenreAsync(genreId);
    }

    public Task<IEnumerable<Movie>> GetAllMoviesAsync()
    {
        return _movieRepository.GetAllAsync();
    }
}