using ZooProject.Models;

namespace ZooProject.Business;

public interface ICarerService
{
    void GetList();

    void Add(Carer carer);

    void Delete(string id);

    void GetById(string id);
}
