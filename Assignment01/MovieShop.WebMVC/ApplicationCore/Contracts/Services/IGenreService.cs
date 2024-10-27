using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Services;

public interface IGenreService
{
    int AddGenre(Genre genre);
    
    int UpdateGenre(Genre genre);
    
    
    int DeleteGenre(int id);
    
    IEnumerable<Genre> GetAllGenres();
    
    Genre GetGenreById(int id);
}