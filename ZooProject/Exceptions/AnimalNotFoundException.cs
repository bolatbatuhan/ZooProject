namespace ZooProject.Exceptions;
public class AnimalNotFoundException : Exception
{
    public AnimalNotFoundException(int id) : base($"{id} bulunamadi!") { }
   
}
