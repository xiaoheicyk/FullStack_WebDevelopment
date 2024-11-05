using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using ApplicationCore.Models.ResponseModels;

namespace Infrastructure.Servcies;

public class MovieService:IMovieService
{
    private readonly IMovieRepository _movieRepository;

    public MovieService(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }
    public async Task<List<MovieCardResponseModel>> GetTopRevenueAsync(int number = 20)
    {
        var topMovies = await _movieRepository.GetAllAsync(); // 假设有获取所有电影的方法
        return topMovies.OrderByDescending(m => m.Revenue)
            .Take(number)
            .Select(m => new MovieCardResponseModel()
            {
                Id = m.Id,
                Title = m.Title,
                Revenue = m.Revenue,
                PosterUrl = m.PosterUrl
            }).ToList();
    }

    public Task<IEnumerable<Movie>> GetMoviesByGenreAsync(int genreId)
    {
        
        return _movieRepository.GetMoviesByGenreAsync(genreId);
    }

    public Task<IEnumerable<Movie>> GetAllMoviesAsync()
    {
        return _movieRepository.GetAllAsync();
    }

    public Task<Movie> GetMovieByIdAsync(int id)
    {
        return _movieRepository.GetByIdAsync(id);
    }
}