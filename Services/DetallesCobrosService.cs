using AlainaGarcia_Ap1_P1.DAL;
using AlainaGarcia_Ap1_P1.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AlainaGarcia_Ap1_P1.Service;

public class DetallesCobrosService
{
    private readonly Contexto _contexto;

    public DetallesCobrosService(Contexto contexto)
    {
        _contexto = contexto;
    }

    public async Task<List<Prestamos>> Listar(Expression<Func<Prestamos, bool>> criterio)
    {
        return await _contexto.Prestamos
            .AsNoTracking().Where(criterio).ToListAsync();
    }
}
