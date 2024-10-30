using System.Linq.Expressions;
using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;

namespace Infrastructure.Repositories;

public class MovieRepository: IMovieRepository
{
    private readonly IMovieRepository _movieRepository;

    public MovieRepository(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }


    public Task<int> InsertAsync(Movie entity)
    {
        return _movieRepository.InsertAsync(entity);
    }

    public Task<int> UpdateAsync(Movie entity)
    {
        return _movieRepository.UpdateAsync(entity);
    }

    public Task<int> DeleteAsync(int Id)
    {
        return _movieRepository.DeleteAsync(Id);
    }

    public Task<IEnumerable<Movie>> GetAllAsync()
    {
        return _movieRepository.GetAllAsync();
    }

    public Task<Movie?> GetByIdAsync(int id)
    {
        return _movieRepository.GetByIdAsync(id);
    }

    public Task<int> GetCountAsync(Expression<Func<Movie, bool>> filter = null)
    {
        return _movieRepository.GetCountAsync(filter);
    }
}