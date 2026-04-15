using ClinicaMvc.Models;
using ClinicaMvc.Repositories;
using ClinicaMvc.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaMvc.Controllers;
[Authorize]
public class ConsultasController : Controller
{
    private readonly IConsultaRepository _consultaRepository;
    private readonly IMedicoRepository _medicoRepository;
    private readonly IPacienteRepository _pacienteRepository;

    public ConsultasController(IConsultaRepository consultaRepository, IMedicoRepository medicoRepository, IPacienteRepository pacienteRepository)
    {
        _consultaRepository = consultaRepository;
        _medicoRepository = medicoRepository;
        _pacienteRepository = pacienteRepository;
    }

    // GET: /Consultas
    public IActionResult Index()
    {
        var consultas = _consultaRepository.ListarTodos();

        var viewModels = consultas.Select(c => new ConsultaViewModel
        {
            Id = c.Id,
            NomeMedico = c.Medico.Nome,     // ← navega até o objeto Medico e pega o Nome
            NomePaciente = c.Paciente.Nome, // ← navega até o objeto Paciente e pega o Nome
            DataHora = c.DataHora,
            Status = c.Status.ToString()    // Converte o enum Status para string
        }).ToList();

        return View(viewModels);
    }

    // GET: Consultas/Details/5
    public IActionResult Details(int id)
    {
        var consulta = _consultaRepository .ObterPorId(id);
        if (consulta == null)
        {
            return NotFound();
        }
        return View(consulta);
    }

    // GET: Consultas/Create
    public IActionResult Create()
    {
        ViewBag.Medicos = _medicoRepository.ListarTodos();
        ViewBag.Pacientes = _pacienteRepository.ListarTodos();
        return View();
    }

    // POST: Consultas/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Consulta consulta)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.Medicos = _medicoRepository.ListarTodos();
            ViewBag.Pacientes = _pacienteRepository.ListarTodos();
            return View(consulta);
        }

        _consultaRepository.Criar(consulta);
        return RedirectToAction(nameof(Index));
    }

    // GET: Consultas/Edit/5
    public IActionResult Edit(int id)
    {
        var consulta = _consultaRepository.ObterPorId(id);
        if (consulta == null)
        {
            return NotFound();
        }
        ViewBag.Medicos = _medicoRepository.ListarTodos();
        ViewBag.Pacientes = _pacienteRepository.ListarTodos();
        return View(consulta);
    }

    // POST: Consultas/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, Consulta consulta)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.Medicos = _medicoRepository.ListarTodos();
            ViewBag.Pacientes = _pacienteRepository.ListarTodos();
            return View(consulta);
        }

        _consultaRepository.Atualizar(consulta);
        return RedirectToAction(nameof(Index));
    }

    // GET: Consultas/Delete/5
    public IActionResult Delete(int id)
    {
        var consulta = _consultaRepository.ObterPorId(id);
        if (consulta == null)
        {
            return NotFound();
        }
        return View(consulta);
    }

    // POST: Consultas/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        var consulta = _consultaRepository.ObterPorId(id);
        if (consulta == null)
        {
            return NotFound();
        }
        _consultaRepository.Deletar(consulta);
        return RedirectToAction(nameof(Index));
    }
}