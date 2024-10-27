using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Repositories;

public interface IMovieRepository:IRepository<Movie>
{
    IEnumerable<Movie> GetMoviesWithGenres();
    
    IEnumerable<Movie> GetTopRevenueMovies(int number=20);
}