using System.ComponentModel.DataAnnotations;

namespace ClinicaMvc.Models;

public class Medico
{
    public int Id { get; set; }
    [Required(ErrorMessage = "O nome do médico é obrigatório.")]
    [StringLength(100, MinimumLength = 3,
        ErrorMessage = "O nome deve ter entre 3 e 100 caracteres.")]
    public string Nome { get; set; } = string.Empty; // Tornar obrigatório
    [Required(ErrorMessage = "O CRM do médico é obrigatório.")]
    [RegularExpression(@"^\d{1,6}\/[A-Z]{2}$", ErrorMessage = "O CRM deve estar no formato correto (ex: 000000/UF.")]
    public string CRM { get; set; } = string.Empty;
    [Required(ErrorMessage = "A especialidade do médico é obrigatória.")]
    public Especialidades Especialidade { get; set; }

    // Navegation Property
    public ICollection<Consulta> Consultas { get; set; } = new List<Consulta>();

    public enum Especialidades
    {
        Cardiologia,
        Dermatologia,
        Endocrinologia,
        Gastroenterologia,
        Ginecologia,
        Neurologia,
        Oftalmologia,
        Ortopedia,
        Pediatria,
        Psiquiatria,
        Radiologia,
        Reumatologia,
        Urologia
    }
}
