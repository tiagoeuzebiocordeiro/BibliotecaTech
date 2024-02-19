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
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
