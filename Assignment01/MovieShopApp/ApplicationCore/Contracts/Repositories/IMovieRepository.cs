using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Repositories;

public interface IMovieRepository: IRepository<Movie>
{
    Task<IEnumerable<Movie>> GetMoviesByGenreAsync(int genreId);

    Task<IEnumerable<Movie>> GetTopRatedMovies();
    
    Task<IEnumerable<Movie>> GetHightestGrossingMovies();
    
    Task<IEnumerable<Movie>> GetMovieReviews(int movieId);
}