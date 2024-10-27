using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Infrastruture.Data;

namespace Infrastruture.Repositories;

public class MovieRepository : BaseRepository<Movie>, IMovieRepository
{
    private readonly MovieShopDbContext _context;
    public MovieRepository(MovieShopDbContext c) : base(c)
    {
        _context = c;
    }

    public IEnumerable<Movie> GetTopRevenueMovies(int number = 20)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Movie> GetMoviesWithGenre()
    {
        throw new NotImplementedException();
    }
}