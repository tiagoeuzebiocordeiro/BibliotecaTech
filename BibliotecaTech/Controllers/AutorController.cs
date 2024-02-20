using BibliotecaTech.Data;
using BibliotecaTech.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace BibliotecaTech.Controllers
{
    public class AutorController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AutorController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<AutorModel> autores = _context.Autores;
            return View(autores);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(AutorModel model)
        {
            if (ModelState.IsValid)
            {
                _context.Autores.Add(model);
                _context.SaveChanges();
                TempData["MensagemSucesso"] = "Autor cadastrado com sucesso!";
                return RedirectToAction("Index");
            }
            TempData["MensagemErro"] = "Ocorreu um erro ao cadastrar o autor!";
            return View();
        }

        [HttpGet]
        public IActionResult Update(int? id) 
        {
            if (id == null || id == 0) 
            {
                return NotFound();
            }
            AutorModel autor = _context.Autores.FirstOrDefault(x => x.Id == id);
            if (autor == null)
            {
                return NotFound();
            }
            return View(autor);
        }

        [HttpPost]
        public IActionResult Update(AutorModel model)
        {
            if (ModelState.IsValid)
            {
                _context.Autores.Update(model);
                _context.SaveChanges();
                TempData["MensagemSucesso"] = "Autor atualizado com sucesso!";
                return RedirectToAction("Index");
            }
            TempData["MensagemErro"] = "Ocorreu um erro ao atualizar o autor!";

            return View();
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            AutorModel autor = _context.Autores.FirstOrDefault(x => x.Id==id);
            if (autor == null)
            {
                return NotFound();
            }
            return View(autor);
        }

        [HttpPost]
        public IActionResult Delete(AutorModel model)
        {
            if (model == null)
            {
                return NotFound();
            }
            _context.Autores.Remove(model);
            _context.SaveChanges();
            TempData["MensagemSucesso"] = "Deleção realizada com sucesso!";
            return RedirectToAction("Index");
        }
    }
}
