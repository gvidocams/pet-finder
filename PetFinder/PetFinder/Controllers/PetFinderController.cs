using Microsoft.AspNetCore.Mvc;
using PetFinder.Core.Models;
using PetFinder.Data;

namespace PetFinder.Controllers;

[Route("api/pet")]
public class PetFinderController : Controller
{
    private readonly PetFinderDbContext _context;

    public PetFinderController(
        PetFinderDbContext context)
    {
        _context = context;
    }

    [HttpGet, Route("{id:int}")]
    public IActionResult GetPetById(int id)
    {
        var pet = _context.Pets.FirstOrDefault(pet => pet.Id == id);

        return Ok(pet);
        
        new List<string>.Orde
    }

    [HttpPost, Route("")]
    public IActionResult CreatePet(Pet pet)
    {
        _context.Pets.Add(pet);

        _context.SaveChanges();

        return Ok(pet);
    }
}