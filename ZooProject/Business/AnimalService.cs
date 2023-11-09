using ZooProject.Data;
using ZooProject.Exceptions;
using ZooProject.Models;

namespace ZooProject.Business;

public class AnimalService : IAnimalService
{
    private readonly IAnimalRepository _animalrepository;
    public AnimalService(IAnimalRepository animalRepository)
    {
        _animalrepository = animalRepository;
    }
    public void Add(Animal animal)
    {
        try
        {
            AddRules(animal);
            _animalrepository.Add(animal);
            GetList();
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.Message);
        }
        
    }

    public void Delete(int id)
    {
        try
        {
            _animalrepository.Delete(id);
            GetList();
        }catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void GetById(int id)
    {
        try
        {
            Animal? animal = _animalrepository.GetById(id);
        }catch (Exception ex)
        {
            Console.WriteLine(ex.Message); 
        }
    }

    public void GetList()
    {
        List<Animal> animals = new List<Animal>();
        animals.ForEach(animal => Console.WriteLine(animal));
    }

    private void AddRules(Animal animal)
    {
        if(animal.Name.Length < 2 || animal.Genre.Length < 2)
        {
            throw new AnimalNameAndGenreException(animal.Name,animal.Genre);
        }
        
    }
}
