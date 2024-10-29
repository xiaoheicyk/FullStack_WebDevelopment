using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;

namespace Infrastruture.Services;

public class AccountService:IAccountService
{
    private IAccountRepository _accountRepository;

    public AccountService(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }
    public Task<User> RegisterAsync(string username, string password, string email)
    {
        throw new NotImplementedException();
    }

    public Task<User> LoginAsync(string username, string password)
    {
        throw new NotImplementedException();
    }

    public Task UpdateUserAsync(User user)
    {
        throw new NotImplementedException();
    }

    public Task DeleteUserAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<User> GetUserByIdAsync(int userId)
    {
        throw new NotImplementedException();
    }
}