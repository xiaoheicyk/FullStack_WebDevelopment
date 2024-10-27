namespace ApplicationCore.Contracts.Repositories;

public interface IRepository<T> where T : class
{
    //CRUD: Insert, delete, select,update,get,count, getbyid
    int Insert(T entity);
    
    int Update(T entity);
    
    int Delete(T entity);
    
    IEnumerable<T> GetAll();
    
    T GetById(int id);
    
    
}