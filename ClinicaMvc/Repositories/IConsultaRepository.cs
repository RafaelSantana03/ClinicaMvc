using ClinicaMvc.Models;

namespace ClinicaMvc.Repositories;

public interface IConsultaRepository
{
    List<Consulta> ListarTodos();
    Consulta? ObterPorId(int id);
    void Criar(Consulta consulta);
    void Atualizar(Consulta consulta);
    void Deletar(Consulta consulta);
}
