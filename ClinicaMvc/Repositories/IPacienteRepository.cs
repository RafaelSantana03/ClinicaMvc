using ClinicaMvc.Models;

namespace ClinicaMvc.Repositories;

public interface IPacienteRepository
{
    List<Paciente> ListarTodos();
    Paciente? ObterPorId(int id);
    void Criar(Paciente paciente);
    void Atualizar(Paciente paciente);
    void Deletar(Paciente paciente);
}