using Microsoft.EntityFrameworkCore;
using PetFinder.Core.Models;

namespace PetFinder.Data;

public class PetFinderDbContext : DbContext
{
    public PetFinderDbContext(DbContextOptions<PetFinderDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Pet> Pets { get; set; }
}