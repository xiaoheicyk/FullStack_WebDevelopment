using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Infrastruture.Data;
using Infrastruture.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class AccountRepository:BaseRepository<Account>,IAccountRepository
{
    private readonly MovieShopDbContext _context;
    public AccountRepository(MovieShopDbContext c) : base(c)
    {
    }
    public async Task<User> GetUserByEmailAsync(string email)
    {
        return await _context.Users.SingleOrDefaultAsync(u => u.Email == email);
    }
}