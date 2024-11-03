using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class GenreRepository:BaseRepository<Genre>,IGenreRepository
{
    private readonly MovieShopDbContext _context;
    public GenreRepository(MovieShopDbContext context) : base(context)
    {
        _context = context;
    }
}