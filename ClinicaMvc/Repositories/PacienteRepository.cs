
using ClinicaMvc.Data;
using ClinicaMvc.Models;

namespace ClinicaMvc.Repositories;

public class PacienteRepository : IPacienteRepository
{
    private readonly AppDbContext _context;
    public PacienteRepository(AppDbContext context)
    {
        _context = context;
    }
    public List<Paciente> ListarTodos()
    {
        return _context.Pacientes.ToList();
    }

    public Paciente? ObterPorId(int id)
    {
        return _context.Pacientes.Find(id);
    }

    public void Criar(Paciente paciente)
    {
        _context.Pacientes.Add(paciente);
        _context.SaveChanges();
    }

    public void Atualizar(Paciente paciente)
    {
        _context.Pacientes.Update(paciente);
        _context.SaveChanges();
    }

    public void Deletar(Paciente paciente)
    {
        _context.Pacientes.Remove(paciente);
        _context.SaveChanges();
    }
}
