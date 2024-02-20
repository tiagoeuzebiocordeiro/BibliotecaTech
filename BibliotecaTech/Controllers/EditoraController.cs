using BibliotecaTech.Data;
using BibliotecaTech.Models;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaTech.Controllers
{
    public class EditoraController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EditoraController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<EditoraModel> editoras = _context.Editoras;
            return View(editoras);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EditoraModel editora)
        {
            if (ModelState.IsValid)
            {
                _context.Editoras.Add(editora);
                _context.SaveChanges();
                TempData["MensagemSucesso"] = "Cadastro realizado com sucesso!";
                return RedirectToAction("Index");
            }

            TempData["MensagemErro"] = "Ocorreu um erro ao realizar o cadastro!";

            return View();
        }

        [HttpGet]
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            EditoraModel editora = _context.Editoras.FirstOrDefault(x => x.Id == id);
            if (editora == null)
            {
                return NotFound();
            }
            return View(editora);
        }

        [HttpPost]
        public IActionResult Update(EditoraModel editora)
        {
            if (ModelState.IsValid)
            {
                _context.Editoras.Update(editora);
                _context.SaveChanges();

                TempData["MensagemSucesso"] = "Edição realizada com sucesso!";

                return RedirectToAction("Index");
            }

            TempData["MensagemErro"] = "Ocorreu um erro ao realizar a edição!";

            return View();
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            EditoraModel editora = _context.Editoras.FirstOrDefault(x => x.Id == id);
            if (editora == null)
            {
                return NotFound();
            }
            return View(editora);
        }

        [HttpPost]
        public IActionResult Delete(EditoraModel editora)
        {
            if (editora == null)
            {
                return NotFound();

            }
            _context.Editoras.Remove(editora);
            _context.SaveChanges();

            TempData["MensagemSucesso"] = "Deleção realizada com sucesso!";

            return RedirectToAction("Index");
        }
    }
}
