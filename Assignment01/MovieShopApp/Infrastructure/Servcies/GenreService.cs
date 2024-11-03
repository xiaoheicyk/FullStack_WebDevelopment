using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using Infrastructure.Repositories;

namespace Infrastructure.Servcies;

public class GenreService:IGenreService
{
    private readonly IGenreRepository _genreRepository;

    public GenreService(IGenreRepository genreRepository)
    {
        _genreRepository = genreRepository;
    }
    public Task<IEnumerable<Genre>> GetAllGenresAsync()
    {
        return _genreRepository.GetAllAsync();
    }

    public Task<Genre> GetGenreByIdAsync(int id)
    {
        return _genreRepository.GetByIdAsync(id);
    }
}