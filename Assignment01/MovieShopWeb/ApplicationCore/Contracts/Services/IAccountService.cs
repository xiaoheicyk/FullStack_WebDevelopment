using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Services;

public interface IAccountService
{
    Task<User> RegisterAsync(string username, string password, string email);
    Task<User> LoginAsync(string username, string password);
    Task UpdateUserAsync(User user);
    Task DeleteUserAsync(int userId);
    Task<User> GetUserByIdAsync(int userId);
}