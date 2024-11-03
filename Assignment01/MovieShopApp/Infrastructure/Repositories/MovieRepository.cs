using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class MovieRepository:BaseRepository<Movie>,IMovieRepository
{
    private readonly MovieShopDbContext _context;
    public MovieRepository(MovieShopDbContext context) : base(context)
    {
        _context = context;
    }
}