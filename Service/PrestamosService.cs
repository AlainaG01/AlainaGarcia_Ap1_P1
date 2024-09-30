using AlainaGarcia_Ap1_P1.DAL;
using AlainaGarcia_Ap1_P1.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AlainaGarcia_Ap1_P1.Service;

public class PrestamosService
{
    private readonly Contexto _contexto;

    public PrestamosService(Contexto contexto)
    {
        _contexto = contexto;
    }

    private async Task<bool> Existe(int prestamoId)
    {
        return await _contexto.Prestamos.AnyAsync(p => p.PrestamosId == prestamoId);
    }

    private async Task<bool> Insertar(Prestamos prestamo)
    {
        _contexto.Prestamos.Add(prestamo);
        return await _contexto.SaveChangesAsync() > 0;
    }

    private async Task<bool> Modificar(Prestamos prestamo)
    {
        _contexto.Update(prestamo);
        return await _contexto.SaveChangesAsync() > 0;
    }

    public async Task<bool> Guardar(Prestamos prestamo)
    {
        if(! await Existe(prestamo.PrestamosId))
        {
            return await Insertar(prestamo);
        }
        else
        {
            return await Modificar(prestamo);
        }
    }

    public async Task<Prestamos> Buscar(int prestamoId)
    {
        return await _contexto.Prestamos.FirstOrDefaultAsync(p => p.PrestamosId == prestamoId);
    }

    public async Task<bool> Eliminar(int prestamoId)
    {
        return await _contexto.Prestamos.Where(p => p.PrestamosId == prestamoId).ExecuteDeleteAsync() > 0;
    }

    public async Task<List<Prestamos>> Listar(Expression<Func<Prestamos, bool>> criterio)
    {
        return await _contexto.Prestamos.AsNoTracking().Where(criterio).ToListAsync();
    }
}
