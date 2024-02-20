namespace BibliotecaTech.Models
{
    public class LivroModel
    {
        
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Isbn { get; set; }
        public int EditoraId { get; set; }
        public int AutorId { get; set; }

        // Propriedades de navegação
        public virtual AutorModel Autor { get; set; }
        public virtual EditoraModel Editora { get; set; }
    }
}
