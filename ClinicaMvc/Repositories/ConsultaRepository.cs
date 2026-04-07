using ClinicaMvc.Models;
using ClinicaMvc.Data;
using Microsoft.EntityFrameworkCore;

namespace ClinicaMvc.Repositories;

public class ConsultaRepository : IConsultaRepository
{
    private readonly AppDbContext _context; 
    public ConsultaRepository(AppDbContext context)
    {
        _context = context;
    }
    public List<Consulta> ListarTodos()
    {
        var consultas = _context.Consultas
            .Include(c => c.Medico)
            .Include(c => c.Paciente)
            .ToList();
        return consultas;
    }

    public Consulta? ObterPorId(int id)
    {
        return _context.Consultas
            .Include(c => c.Medico)
            .Include(c => c.Paciente)
            .FirstOrDefault(c => c.Id == id);
    }

    public void Criar(Consulta consulta)
    {
        _context.Consultas.Add(consulta);
        _context.SaveChanges();
    }

    public void Atualizar(Consulta consulta)
    {
        _context.Consultas.Update(consulta);
        _context.SaveChanges();
    }

    public void Deletar(Consulta consulta)
    {
        _context.Consultas.Remove(consulta);
        _context.SaveChanges();
    }

}
