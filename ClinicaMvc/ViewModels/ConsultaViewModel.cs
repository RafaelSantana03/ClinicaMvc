namespace ClinicaMvc.ViewModels;

public class ConsultaViewModel
{
    public int Id { get; set; }
    public string NomeMedico { get; set; } = string.Empty;
    public string NomePaciente { get; set; } = string.Empty;
    public DateTime DataHora { get; set; }
    public string Status { get; set; } = string.Empty;
}