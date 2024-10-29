using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Repositories;

public interface ICastRepository: IRepository<Cast>
{
    Task<Cast> GetByIdAsync(int id);
    Task<IEnumerable<Cast>> GetAllAsync();
    
}