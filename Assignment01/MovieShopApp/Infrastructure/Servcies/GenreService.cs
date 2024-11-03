using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;

namespace Infrastructure.Servcies;

public class GenreService:IGenreService
{
    private readonly IRepository<Genre> _repository;

    public GenreService(IRepository<Genre> repository)
    {
        _repository = repository;
    }
    public Task<IEnumerable<Genre>> GetAllGenresAsync()
    {
        return _repository.GetAllAsync();
    }

    public Task<Genre> GetGenreByIdAsync(int id)
    {
        return _repository.GetByIdAsync(id);
    }
}