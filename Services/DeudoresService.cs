using AlainaGarcia_Ap1_P1.DAL;
using AlainaGarcia_Ap1_P1.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AlainaGarcia_Ap1_P1.Service;

public class DeudoresService
{
    private readonly Contexto _contexto;

    public DeudoresService(Contexto contexto)
    {
        _contexto = contexto;
    }

    public async Task<List<Deudores>> Listar(Expression<Func<Deudores, bool>> criterio)
    {
        return await _contexto.Deudores.AsNoTracking().Where(criterio).ToListAsync();
    }
}
