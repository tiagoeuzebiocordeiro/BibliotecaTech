using System.ComponentModel.DataAnnotations;

namespace BibliotecaTech.Models
{
    public class AutorModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o nome do autor!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe a data de nascimento do autor!")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime DataNascimento { get; set; }
    }
}
