namespace ClinicaMvc.Models;

public class Consulta
{
    public int Id { get; set; }

    // Chaves estrangeiras
    public int MedicoId { get; set; }
    public int PacienteId { get; set; }

    public DateTime DataHora { get; set; }
    public string? Observacoes { get; set; }
    public StatusConsulta Status { get; set; } = StatusConsulta.Agendada;

    // Navegation Properties
    public Medico Medico { get; set; } = null!;
    public Paciente Paciente { get; set; } = null!;

    public enum StatusConsulta
    {
        Agendada,
        Realizada,
        Cancelada
    }
}
