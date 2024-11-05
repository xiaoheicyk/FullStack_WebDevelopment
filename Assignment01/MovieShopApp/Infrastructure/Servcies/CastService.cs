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
    public async Task<CastDetailsResponseModel> GetCastDetailsWithMoviesAsync(int id)
    {
        var castDetails = await _castRepository.GetByIdAsync(id);
        if (castDetails == null)
        {
            throw new Exception($"Cast with id: {id} not found");
        }
        var castDetailsModels = new CastDetailsResponseModel
        {
            Id = castDetails.Id, Gender = castDetails.Gender, ProfilePath = castDetails.ProfilePath,
            Name = castDetails.Name, TmdbUrl = castDetails.TmdbUrl,
            Movies = castDetails.MoviesOfCasts.Select(mc => new MovieCardResponseModel()
            {
                Id = mc.Movie.Id, Title = mc.Movie.Title, PosterUrl = mc.Movie.PosterUrl,
                ReleaseDate = mc.Movie.ReleaseDate.GetValueOrDefault()
            })
        };
        return castDetailsModels;
    }

    public Task<List<Cast>> GetCastDetailsWithMoviesAsync()
    {
        throw new NotImplementedException();
    }
}