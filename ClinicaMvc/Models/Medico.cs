namespace ClinicaMvc.Models;

public class Medico
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? CRM { get; set; }
    public string? Especialidade { get; set; }

    // Navegation Property
    public ICollection<Consulta> Consultas { get; set; } = new List<Consulta>();
}
