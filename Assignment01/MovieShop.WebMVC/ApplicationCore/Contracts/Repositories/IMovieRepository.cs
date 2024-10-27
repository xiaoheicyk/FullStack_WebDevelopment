using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Repositories;

public interface IMovieRepository:IRepository<Movie>
{
    IEnumerable<Movie> GetTopRevenueMovies(int count=20);
    
    IEnumerable<Movie> GetMoviesWithGenre();
    
}