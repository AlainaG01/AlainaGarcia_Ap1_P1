using AlainaGarcia_Ap1_P1.Models;
using Microsoft.EntityFrameworkCore;

namespace AlainaGarcia_Ap1_P1.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }

    public DbSet<Prestamos> Prestamos { get; set; } 

    public DbSet<Deudores> Deudores { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Deudores>().HasData(new List<Deudores>()
        {
            new Deudores(){DeudorId=1, Nombres="Juan Perez"},
            new Deudores(){DeudorId=2, Nombres="Alina Garcia"},
            new Deudores(){DeudorId=3, Nombres="Erian Brito"}
        });
    }

}
