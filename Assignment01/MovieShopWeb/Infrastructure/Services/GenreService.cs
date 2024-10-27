using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;

namespace Infrastruture.Services;

public class GenreService:IGenreService
{
    private IGenreRepository _repository;

    public GenreService(IGenreRepository repo)
    {
        _repository = repo;
    }
    public int AddGenre(Genre genre)
    {
        return _repository.Insert(genre);
    }

    public int UpdateGenre(Genre genre,int id)
    {
        if (id == genre.Id)
        {
            return _repository.Update(genre);
        }

        return 0;
    }

    public int DeleteGenre(int id)
    {
        return _repository.Delete(id);
    }

    public IEnumerable<Genre> GetAllGenres()
    {
        return _repository.GetAll();
    }

    public Genre GetGenreById(int id)
    {
        return _repository.GetById(id);
    }
}