using System.ComponentModel.DataAnnotations;

namespace BibliotecaTech.Models
{
    public class EditoraModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome da editora!")]
        public string Nome { get; set; }
    }
}
