using ClinicaMvc.Models;
using ClinicaMvc.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaMvc.Controllers;

public class PacientesController : Controller
{
    private readonly IPacienteRepository _repository;

    public PacientesController(IPacienteRepository repository)
    {
        _repository = repository;
    }

    // GET: /Pacientes
    public IActionResult Index()
    {
        var pacientes = _repository.ListarTodos();

        var viewModels = pacientes.Select(p => new Paciente
        {
            Id = p.Id,
            Nome = p.Nome,
            CPF = p.CPF,
            DataNascimento = p.DataNascimento
        }).ToList();

        return View(viewModels);
    }

    // GET: Pacientes/Details/5
    public IActionResult Details(int id)
    {
        var paciente = _repository.ObterPorId(id);
        if (paciente == null)
        {
            return NotFound();
        }
        return View(paciente);
    }

    // GET: Pacientes/Create
    // Exibe o formulário de criação de um novo paciente
    public IActionResult Create()
    {
        return View();
    }

    //Post: Pacientes/Create
    // Salva um novo paciente no banco de dados
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Paciente paciente)
    {
        if (!ModelState.IsValid)
            return View(paciente);

        _repository.Criar(paciente);
        return RedirectToAction(nameof(Index));
    }

    // GET: Pacientes/Edit/5
    // Exibe o formulário de edição de um paciente
    public IActionResult Edit(int id)
    {
        var paciente = _repository.ObterPorId(id);
        if (paciente == null)
        {
            return NotFound();
        }
        return View(paciente);
    }

    // POST: Pacientes/Edit/5
    // Salva as alterações feitas em um paciente existente
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, Paciente paciente)
    {
        if (!ModelState.IsValid)
            return View(paciente);

        _repository.Atualizar(paciente);
        return RedirectToAction(nameof(Index));
    }

    //GET: Pacientes/Delete/5
    public IActionResult Delete(int id)
    {
        var paciente = _repository.ObterPorId(id);
        if (paciente == null)
        {
            return NotFound();
        }
        return View(paciente);
    }

    // POST: Pacientes/Delete/5
    // Exclui um paciente do banco de dados
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        var paciente = _repository.ObterPorId(id);
        if (paciente == null)
        {
            return NotFound();
        }
        _repository.Deletar(paciente);
        return RedirectToAction(nameof(Index));
    }
}