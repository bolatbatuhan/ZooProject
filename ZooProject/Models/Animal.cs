namespace ZooProject.Models;

public class Animal : EntityBase<int>
{
    public string Genre { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }

    public string NutritionHabits { get; set; }

    public string CarerId { get; set; }

    public string Carer { get; set; }

    public override string ToString()
    {
        return $"Id : {Id}, Hayvan :  {Name} Tür : {Genre},Beslenme Turu : {NutritionHabits}, Aciklama : {Description} , CarerId : {CarerId}, Bakici : {Carer}";
    }
}
