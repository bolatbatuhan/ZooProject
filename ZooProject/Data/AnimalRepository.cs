using ZooProject.Exceptions;
using ZooProject.Models;

namespace ZooProject.Data;

public class AnimalRepository : IAnimalRepository
{
    private readonly List<Animal> _animalData;

    public AnimalRepository()
    {
        _animalData = new List<Animal>()
        {
         new Animal { Id = 1, CarerId = "A", Name = "Panda", Genre = "Memeli", NutritionHabits = "Etcil", Description = "Soyu tehlikede olan bir hayvan" },
         new Animal { Id = 2, CarerId = "A", Name = "Aslan", Genre = "Memeli", NutritionHabits = "Etcil", Description = "Soyu tehlikede olan bir hayvan" },
         new Animal { Id = 3, CarerId = "B", Name = "Yilan", Genre = "Surungen", NutritionHabits = "Etcil", Description = "Soyu tehlikede olan bir hayvan" },
         new Animal { Id = 4, CarerId = "B", Name = "Komodo Ejderi", Genre = "Surungen", NutritionHabits = "Etcil", Description = "Soyu tehlikede olan bir hayvan" },
         new Animal { Id = 5, CarerId = "C", Name = "Kel Kartal", Genre = "Kus", NutritionHabits = "Etcil", Description = "Soyu tehlikede olan bir hayvan" },
         new Animal { Id = 5, CarerId = "D", Name = "Zurafa", Genre = "Memeli", NutritionHabits = "Otcul", Description = "Soyu tehlikede olan bir hayvan" },
         new Animal { Id = 5, CarerId = "D", Name = "Bizon", Genre = "Memeli", NutritionHabits = "Otcul", Description = "Soyu tehlikede olan bir hayvan" },
        };
    }

    public void Add(Animal animal)
    {
        _animalData.Add(animal);
    }

    public void Delete(int id)
    {
        Animal? animal = _animalData.Where(x => x.Id == id).FirstOrDefault();

        if(animal is null)
        {
            throw new AnimalNotFoundException(id);
        }
        _animalData.Remove(animal);
        
    }

    public List<Animal> GetAll()
    {
        return _animalData;
    }

    public Animal? GetById(int id)
    {
        Animal? animal = _animalData.SingleOrDefault(x => x.Id == id);

        if(animal is not null)
        {
            return animal;
        }
        return null;
    }
}
