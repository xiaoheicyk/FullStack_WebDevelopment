using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Services;

public interface IMovieService
{
    Task<IEnumerator<Movie>> GetAllAsync();
    
    
}