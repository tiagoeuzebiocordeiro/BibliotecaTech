using BibliotecaTech.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaTech.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        
        public DbSet<EditoraModel> Editoras { get; set; }
        public DbSet<AutorModel> Autores { get; set; }
        public DbSet<LivroModel> Livros { get; set; }
    }
}
