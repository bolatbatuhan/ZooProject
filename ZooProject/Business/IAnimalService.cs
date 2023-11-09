using ZooProject.Models;

namespace ZooProject.Business;

public interface IAnimalService
{
    void GetList();

    void Add(Animal animal);

    void Delete(int id);

    void GetById(int id);

}
