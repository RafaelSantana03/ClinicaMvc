using ClinicaMvc.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaMvc.Controllers;

[Authorize]
public class HomeController : Controller
{
    private readonly IMedicoRepository _medicoRepository;
    private readonly IPacienteRepository _pacienteRepository;
    private readonly IConsultaRepository _consultaRepository;

    public HomeController(
        IMedicoRepository medicoRepository,
        IPacienteRepository pacienteRepository,
        IConsultaRepository consultaRepository)
    {
        _medicoRepository = medicoRepository;
        _pacienteRepository = pacienteRepository;
        _consultaRepository = consultaRepository;
    }

    public IActionResult Index()
    {
        ViewBag.TotalMedicos = _medicoRepository.ListarTodos().Count;
        ViewBag.TotalPacientes = _pacienteRepository.ListarTodos().Count;
        ViewBag.TotalConsultas = _consultaRepository.ListarTodos().Count;
        ViewBag.ProximasConsultas = _consultaRepository.ListarTodos()
            .Where(c => c.DataHora >= DateTime.Today)
            .OrderBy(c => c.DataHora)
            .Take(5)
            .ToList();

        return View();
    }
}