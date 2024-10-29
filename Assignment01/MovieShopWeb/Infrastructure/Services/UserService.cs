using System.Security.Cryptography;
using System.Text;
using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using ApplicationCore.Models;

namespace Infrastruture.Services;

public class UserService:IUserService
{
    
    private IUserRepository _repository;

    public UserService(IUserRepository repo)
    {
        _repository = repo;
    }


    public async Task<User> RegisterAsync(LoginModel model)
    {
        var existingUser = await _repository.GetUserByEmailAsync(model.Email);
        if (existingUser != null)
        {
            throw new InvalidOperationException("User already exists.");
        }
        
        var user = new User
        {
            Email = model.Email,
            HashedPassword = model.Password
        };

        
        return await _repository.AddAsync(user);
    }

    public async Task<User> LoginAsync(LoginModel model)
    {
        var user = await _repository.GetUserByEmailAsync(model.Email);
        
        if (user == null || model.Password!= user.HashedPassword)
        {
            throw new UnauthorizedAccessException("Invalid email or password."); 
        }

        return user;

        
    }
    

}