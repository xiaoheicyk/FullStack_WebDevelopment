using System.Globalization;
using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using ApplicationCore.Models.ResponseModels;

namespace Infrastructure.Servcies;

public class CastService:ICastService
{
    private readonly ICastRepository _castRepository;

    public CastService(ICastRepository castRepository)
    {
        _castRepository = castRepository;
    }

    public Task<List<Cast>> GetCastDetailsWithMoviesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Cast>> GetAllCastsAsync()
    {
        return _castRepository.GetAllAsync();
    }
}