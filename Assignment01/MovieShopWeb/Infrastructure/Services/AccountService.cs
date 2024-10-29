using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using ApplicationCore.Models;

namespace Infrastruture.Services;

public class AccountService:IAccountService
{
    private IAccountRepository _accountRepository;

    public AccountService(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }

    public Task<User> LoginAsync(LoginModel model)
    {
        throw new NotImplementedException();
    }

    public Task<User> RegisterAsync(RegisterModel model)
    {
        throw new NotImplementedException();
    }
}