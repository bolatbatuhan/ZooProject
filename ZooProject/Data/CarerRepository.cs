using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooProject.Exceptions;
using ZooProject.Models;

namespace ZooProject.Data;

public class CarerRepository : ICarerRepository
{
    private readonly List<Carer> _carerData;

    public CarerRepository()
    {
        _carerData = new List<Carer>()
        {
            new Carer { Id = "A", Name = "Ali" },
            new Carer { Id = "B", Name = "Batu"},
            new Carer { Id = "C", Name = "Esra"},
            new Carer { Id = "D", Name = "Eylul"}
        };
        
    }

    public void Add(Carer carer)
    {
        _carerData.Add(carer);
    }

    public void Delete(string id)
    {
        Carer? carer = _carerData.SingleOrDefault(c=> c.Id == id);
        if(carer is not null)
        {
            _carerData.Remove(carer);
        }
    }

    public List<Carer> GetAll()
    {
        return _carerData;
    }

    public Carer? GetById(string id)
    {
        Carer? carer = _carerData.SingleOrDefault(c=> c.Id == id);

        if(carer == null)
        {
            throw new CarerNotFoundException(id);
        }
        return carer;
    }
}
