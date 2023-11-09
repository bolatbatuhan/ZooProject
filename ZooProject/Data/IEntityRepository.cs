using ZooProject.Models;

namespace ZooProject.Data;

public interface IEntityRepository<TEntity,TId>
{
    void Add(TEntity animal);

    void Delete(TId id);

    List<TEntity> GetAll();

    TEntity? GetById(TId id);
}
