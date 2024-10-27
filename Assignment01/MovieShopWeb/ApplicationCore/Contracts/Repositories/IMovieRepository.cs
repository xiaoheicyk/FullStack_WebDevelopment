using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Repositories;

public interface IMovieRepository
{ 
        IEnumerable<Movie> GetTopRevenueMovies(int number=20);
        IEnumerable<Movie> GetMoviesWithGenre();
    
}