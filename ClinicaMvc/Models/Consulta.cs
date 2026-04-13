using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ClinicaMvc.Models;

public class Consulta
{
    public int Id { get; set; }

    // Chaves estrangeiras
    public int MedicoId { get; set; }
    public int PacienteId { get; set; }

    [Display(Name = "Data e Hora")]
    [DataType(DataType.DateTime)]
    public DateTime DataHora { get; set; }
    [Display(Name = "Observações")]
    public string? Observacoes { get; set; } // Tornar opcional
    [Display(Name = "Status")]
    public StatusConsulta Status { get; set; } = StatusConsulta.Agendada;

    // Navegation Properties
    [ValidateNever]
    public Medico Medico { get; set; } = null!;
    [ValidateNever]
    public Paciente Paciente { get; set; } = null!;

    public enum StatusConsulta
    {
        Agendada,
        Realizada,
        Cancelada
    }
}
