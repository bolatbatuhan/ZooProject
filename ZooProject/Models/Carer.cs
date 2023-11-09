namespace ZooProject.Models;

public class Carer : EntityBase<string>
{
    public string Name { get; set; }

    public override string ToString()
    {
        return $"Id : {Id}, Name : {Name}";
    }
}
