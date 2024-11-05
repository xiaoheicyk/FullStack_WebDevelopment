using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class CastRepository:BaseRepository<Cast>,ICastRepository
{
    private readonly MovieShopDbContext _context;
    public CastRepository(MovieShopDbContext context) : base(context)
    {
        _context = context;
    }
}