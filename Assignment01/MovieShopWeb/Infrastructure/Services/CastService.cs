using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;

namespace Infrastruture.Services;

public class CastService:ICastService
{
    private ICastRepository _repository;

    public CastService(ICastRepository repo)
    {
        _repository = repo;
    }
    public int AddCast(Cast cast)
    {
        throw new NotImplementedException();
    }

    public int UpdateCast(Cast cast, int id)
    {
        throw new NotImplementedException();
    }

    public int DeleteCast(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Cast> GetAllCasts()
    {
        return _repository.GetAll();
    }

    public Cast GetCastById(int id)
    {
        throw new NotImplementedException();
    }
}