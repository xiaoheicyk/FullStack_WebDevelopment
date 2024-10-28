using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Services;

public interface ICastService
{
    int AddCast(Cast cast);
    
    int UpdateCast(Cast cast,int id);
    
    int DeleteCast(int id);
    
    IEnumerable<Cast> GetAllCasts();
    
    Cast GetCastById(int id);
}