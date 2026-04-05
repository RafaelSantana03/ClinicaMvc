namespace ClinicaMvc.Models;

public class Paciente
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? CPF { get; set; }
    public DateTime DataNascimento { get; set; }

    // Navegation Property
    public ICollection<Consulta> Consultas { get; set; } = new List<Consulta>();
}
