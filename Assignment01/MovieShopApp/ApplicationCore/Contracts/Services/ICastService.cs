using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Services;

public interface ICastService
{
    Task<List<Cast>> GetCastDetailsWithMoviesAsync();
    Task<IEnumerable<Cast>> GetAllCastsAsync();
}