using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Infrastruture.Data;
using Infrastruture.Repositories;

namespace Infrastructure.Repositories;

public class CastRepository:BaseRepository<Cast>,ICastRepository
{
    public CastRepository(MovieShopDbContext c) : base(c)
    {
    }
}