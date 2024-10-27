using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;

namespace Infrastruture.Services;

public class MovieService:IMovieService
{
    private IMovieRepository _repository;

    public MovieService(IMovieRepository repo)
    {
        _repository = repo;
    }
    public int AddMovie(Movie movie)
    {
        throw new NotImplementedException();
    }

    public int UpdateMovie(Movie movie, int id)
    {
        throw new NotImplementedException();
    }

    public int DeleteMovie(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Movie> GetAllMovies()
    {
        throw new NotImplementedException();
    }

    public Movie GetMovieById(int id)
    {
        throw new NotImplementedException();
    }
}