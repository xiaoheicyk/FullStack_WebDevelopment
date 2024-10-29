using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Infrastruture.Data;
using Infrastruture.Repositories;

namespace Infrastructure.Repositories;

public class AccountRepository:BaseRepository<Account>,IAccountRepository
{
    public AccountRepository(MovieShopDbContext c) : base(c)
    {
    }
}