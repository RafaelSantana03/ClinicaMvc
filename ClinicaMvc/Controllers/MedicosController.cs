using ClinicaMvc.Models;
using ClinicaMvc.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaMvc.Controllers
{
    public class MedicosController : Controller
    {
        private readonly IMedicoRepository _repository;

        public MedicosController(IMedicoRepository repository)
        {
            _repository = repository;
        }

        // GET: /Medicos
        public IActionResult Index()
        {
            var medicos = _repository.ListarTodos();
            return View(medicos);
        }

        // GET: Medicos/Details/5
        public IActionResult Details(int id)
        {
            var medico = _repository.ObterPorId(id);
            if (medico == null)
            {
                return NotFound();
            }
            return View(medico);
        }

        // GET: Medicos/Create
        public IActionResult Create()
        {
            return View();
        }

        //Post: Medicos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Medico medico)
        {
            if (ModelState.IsValid)
            {
                _repository.Criar(medico);
                return RedirectToAction(nameof(Index));
            }
            return View(medico);

        }

        // POST: Medicos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Medico medico)
        {
            if (ModelState.IsValid)
                return View(medico);

            _repository.Atualizar(medico);
            return RedirectToAction(nameof(Index));

        }

        // GET: Medicos/Delete/5
        public IActionResult Delete(int id)
        {
            var medico = _repository.ObterPorId(id);
            if (medico == null)
            {
                return NotFound();
            }
            return View(medico);
        }

        // POST: Medicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var medico = _repository.ObterPorId(id);
            if (medico == null)
            {
                return NotFound();
            }
            _repository.Deletar(medico);
            return RedirectToAction(nameof(Index));
        }
}
