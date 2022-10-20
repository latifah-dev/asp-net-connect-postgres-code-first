using Microsoft.EntityFrameworkCore;
using CodeFirst.Models.Entities;

namespace CodeFirst.Models;

public class CobaDbContext: DbContext {
    public CobaDbContext(DbContextOptions<CobaDbContext> options): base(options)
    {
        
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Penjual> Penjuals { get; set; }
    public DbSet<Barang> Barangs { get; set; }
}