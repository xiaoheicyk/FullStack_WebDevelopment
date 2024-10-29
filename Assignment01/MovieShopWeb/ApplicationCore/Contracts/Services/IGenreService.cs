using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Services
{
    public interface IGenreService
    {
        Task<int> AddGenreAsync(Genre genre);
        
        Task<int> UpdateGenreAsync(Genre genre, int id);
        
        Task<int> DeleteGenreAsync(int id);
        
        Task<IEnumerable<Genre>> GetAllGenresAsync();
        
        Task<Genre> GetGenreByIdAsync(int id);
    }
}