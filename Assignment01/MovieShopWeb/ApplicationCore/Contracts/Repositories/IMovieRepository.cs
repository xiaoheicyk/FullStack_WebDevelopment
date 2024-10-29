using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Repositories;

public interface IMovieRepository: IRepository<Movie>
{ 
        Task <IEnumerable<Movie>> GetTopRevenueMovies(int number=20);
        Task <IEnumerable<Movie>> GetMoviesWithGenre();
    
}