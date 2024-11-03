using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;

namespace Infrastructure.Servcies;

public class MovieService:IMovieService
{
    public Task<IEnumerable<Movie>> GetTopRevenueAsync(int number = 20)
    {
        throw new NotImplementedException();
    }
}