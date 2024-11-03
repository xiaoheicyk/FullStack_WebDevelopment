using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Repositories;

public interface IMovieRepository: IRepository<Movie>
{
    Task<IEnumerable<Movie>> GetMoviesByGenreAsync(int genreId);
}