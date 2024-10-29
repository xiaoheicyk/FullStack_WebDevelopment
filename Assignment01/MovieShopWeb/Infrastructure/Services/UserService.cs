using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;

namespace Infrastruture.Services;

public class UserService:IUserService
{
    
    private IUserRepository _repository;

    public UserService(IUserRepository repo)
    {
        _repository = repo;
    }

    public async Task<User> GetUserByIdAsync(int userId)
    {
        return await _repository.GetByIdAsync(userId);
    }

    public async Task<List<Purchase>> GetUserPurchasesAsync(int userId)
    {
        return await _repository.GetUserPurchaseAsync(userId);
    }


}