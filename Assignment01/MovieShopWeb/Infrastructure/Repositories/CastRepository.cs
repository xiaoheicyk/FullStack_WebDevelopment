using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Infrastruture.Data;

namespace Infrastruture.Repositories;

public class CastRepository:BaseRepository<Cast>,ICastRepository
{
    public CastRepository(MovieShopDbContext c) : base(c)
    {
    }
}