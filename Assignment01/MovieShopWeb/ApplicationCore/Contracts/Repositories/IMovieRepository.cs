using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Repositories;

public interface IMovieRepository: IRepository<Movie>
{ 
        Task<IEnumerable<Movie>> GetTopRevenueMovies(int number = 20);
        Task<IEnumerable<Movie>> GetHighestGrossingMovies(int number = 10);
        Task<Movie> GetMovieById(int id);
        
        Task<int> AddAsync(Movie movie);
        Task<int> DeleteAsync(int id); 
}