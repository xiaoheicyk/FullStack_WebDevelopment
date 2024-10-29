using ApplicationCore.Entities;
using ApplicationCore.Models;

namespace ApplicationCore.Contracts.Services;

public interface IAccountService
{
    Task<User> LoginAsync(LoginModel model);
    Task<User> RegisterAsync(RegisterModel model);
}
