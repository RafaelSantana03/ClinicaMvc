using System.ComponentModel.DataAnnotations;

namespace ClinicaMvc.Models;

public class Paciente
{
    public int Id { get; set; }
    [Required(ErrorMessage = "O nome do paciente é obrigatório.")]
    [StringLength(100, MinimumLength = 3,
       ErrorMessage = "O nome deve ter entre 3 e 100 caracteres.")]
    public string Nome { get; set; } = string.Empty;
    [Required(ErrorMessage = "O CPF do paciente é obrigatório.")]
    [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "O CPF deve estar no formato correto (ex: 000.000.000-00).")]
    public string CPF { get; set; } = string.Empty;
    [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
    [DataType(DataType.Date)]
    [Display(Name = "Data de Nascimento")]
    public DateTime DataNascimento { get; set; }

    // Navegation Property
    public ICollection<Consulta> Consultas { get; set; } = new List<Consulta>();
}
