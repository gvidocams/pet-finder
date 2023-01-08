using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace PetFinder.Core.Models;

public class User
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}