using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Services;

public interface IGenreService
{
    Task<IEnumerable<Genre>> GetAllGenresAsync();
    Task<Genre> GetGenreByIdAsync(int id);
    
}