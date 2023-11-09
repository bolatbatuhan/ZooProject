namespace ZooProject.Exceptions;

public class CarerNotFoundException : Exception
{
    public CarerNotFoundException(string id) : base($"{id} bulunamadi!") 
    {
        
    }
}
