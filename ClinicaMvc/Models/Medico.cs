namespace ClinicaMvc.Models;

public class Medico
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty; // Tornar obrigatório
    public string CRM { get; set; } = string.Empty;
    public string Especialidade { get; set; } = string.Empty;

    // Navegation Property
    public ICollection<Consulta> Consultas { get; set; } = new List<Consulta>();
}
