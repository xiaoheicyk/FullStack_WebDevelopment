using System.Linq.Expressions;
using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class MovieRepository: BaseRepository<Movie>,IMovieRepository
{
    private readonly MovieShopDbContext _context;

    public MovieRepository(MovieShopDbContext dbContext):base(dbContext)
    {
        _context = dbContext;
    }
    
    
    
}