using ZooProject.Data;
using ZooProject.Exceptions;
using ZooProject.Models;

namespace ZooProject.Business;

public class CarerService : ICarerService
{
    private readonly ICarerRepository _carerrepository;

    public CarerService(ICarerRepository carerRepository)
    {
        _carerrepository = carerRepository;
    }

    public void Add(Carer carer)
    {
        try
        {
            _carerrepository.Add(carer);
            AddRules(carer);
            GetList();
        }catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void Delete(string id)
    {
        try
        {
            _carerrepository.Delete(id);
            GetList();

        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void GetById(string id)
    {
        try
        {
            Carer? carer = _carerrepository.GetById(id);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void GetList()
    {
        List<Carer> carers = new List<Carer>();
        carers.ForEach(c => Console.WriteLine(c));
    }
    private void AddRules(Carer carer)
    {
        if(carer.Name.Length < 2)
        {
            throw new CarerNameException(carer.Name);
        }
    }
}
