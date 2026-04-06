using ClinicaMvc.Models;

namespace ClinicaMvc.Repositories;

public interface IMedicoRepository
{
    // Definir os métodos que serão implementados no MedicoRepository
    // Listar todos os médicos
    List<Medico> ListarTodos();
    Medico? ObterPorId(int id); // ? indica que pode retornar null
    void Criar(Medico medico); 
    void Atualizar(Medico medico);
    void Deletar(Medico medico);
}
