namespace BlibliotecaCentral.Api.Models
{
    public class CadastarLivro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string DataDePublicacao { get; set; }
        public string Editora { get; set; }
    }
}
