namespace PetFinder.Core.Models;

public class Pet
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string? Color { get; set; }
    public string? Description { get; set; }
    public bool IsFound { get; set; }
}