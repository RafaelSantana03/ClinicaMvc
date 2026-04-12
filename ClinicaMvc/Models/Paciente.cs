using System.ComponentModel.DataAnnotations;

namespace ClinicaMvc.Models;

public class Paciente
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string CPF { get; set; } = string.Empty;
    [DataType(DataType.Date)]
    public DateTime DataNascimento { get; set; }

    // Navegation Property
    public ICollection<Consulta> Consultas { get; set; } = new List<Consulta>();
}
