using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Services;

public interface IMovieService
{
    int AddMovie(Movie movie);
    
    int UpdateMovie(Movie movie);
    
    int DeleteMovie(int id);
    
    IEnumerable<Movie> GetAllMovies();
    
    Movie GetMovieById(int id);
}