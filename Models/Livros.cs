namespace LivrosApp.Models
{
    public class Livros {
        public long Id { get; set; }
        public long Isbn { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
    }
}