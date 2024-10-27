using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Infrastruture.Data;

namespace Infrastruture.Repositories;

public class GenreRepository: BaseRepository<Genre>, IGenreRepository
{
    public GenreRepository(MovieShopDbContext c) : base(c)
    {
    }
    
}