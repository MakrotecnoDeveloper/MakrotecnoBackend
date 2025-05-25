using Microsoft.EntityFrameworkCore;
using MakrotecnoBackend.Models;

namespace MakrotecnoBackend.Models;

public class MakrotecnoDbContext : DbContext
{
    public MakrotecnoDbContext(DbContextOptions<MakrotecnoDbContext> options)
        : base(options)
    {
    }

    public DbSet<Usuario> Usuarios { get; set; } = null!;
}