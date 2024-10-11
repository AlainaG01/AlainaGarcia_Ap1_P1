using AlainaGarcia_Ap1_P1.DAL;
using AlainaGarcia_Ap1_P1.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AlainaGarcia_Ap1_P1.Service;

public class CobrosService
{
    private readonly Contexto _contexto;
    
    public CobrosService(Contexto contexto)
    {
        _contexto = contexto;
    }

    private async Task<bool> Existe(int cobroId)
    {
        return await _contexto.Cobros.AnyAsync(c => c.CobroId == cobroId);
    }

    private async Task<bool> Insertar(Cobros cobro)
    {
        _contexto.Cobros.Add(cobro);
        return await _contexto.SaveChangesAsync() > 0;
    }

    private async Task<bool> Modificar(Cobros cobro)
    {
        _contexto.Update(cobro);
        return await _contexto.SaveChangesAsync() > 0;
    }

    public async Task<bool> Guardar(Cobros cobro)
    {
        if (!await Existe(cobro.CobroId))
        {
            return await Insertar(cobro);
        }
        else
        {
            return await Modificar(cobro);
        }
    }

    public async Task<Cobros> Buscar(int cobroId)
    {
        return await _contexto.Cobros.Include(d => d.Deudor)
            .Include(d => d.CobroDetalle)
            .FirstOrDefaultAsync(c => c.CobroId == cobroId);
    }

    public async Task<bool> Eliminar(int cobroId)
    {
        return await _contexto.Cobros.Where(c => c.CobroId == cobroId).ExecuteDeleteAsync() > 0;
    }

    public async Task<List<Cobros>> Listar(Expression<Func<Cobros, bool>> criterio)
    {
        return await _contexto.Cobros.Include(d => d.Deudor)
            .Include(d => d.CobroDetalle).AsNoTracking().Where(criterio).ToListAsync();
    }

    
}
