using ClinicaMvc.Data;
using ClinicaMvc.Models;

namespace ClinicaMvc.Repositories;

public class MedicoRepository : IMedicoRepository
{
    private readonly AppDbContext _context;
    public MedicoRepository(AppDbContext context)
    {
        _context = context;
    }
    public List<Medico> ListarTodos()
    {
        return _context.Medicos.ToList();
    }

    public Medico? ObterPorId(int id)
    {
        return _context.Medicos.Find(id);
    }

    public void Criar(Medico medico)
    {
        _context.Medicos.Add(medico);
        _context.SaveChanges();
    }

    public void Atualizar(Medico medico)
    {
        _context.Medicos.Update(medico);
        _context.SaveChanges();
    }

    public void Deletar(Medico medico)
    {
        _context.Medicos.Remove(medico);
        _context.SaveChanges(); 
    }
}
