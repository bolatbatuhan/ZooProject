namespace ZooProject.Exceptions;

public class AnimalNameAndGenreException : Exception
{
    public AnimalNameAndGenreException(string name, string genre) : base($"Hayvan adi {name} ve  turu en az 2 karakterli olmalidir.{genre} Hayvan : {name}, Tur : {genre}") { }
    
}
