using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Repositories;

public interface IMovieRepository: IRepository<Movie>
{ 
        Task<IEnumerable<Movie>> GetTopRevenueMoviesAsync(int number = 20);
        Task<Movie> GetMovieByIdAsync(int id);
        
}