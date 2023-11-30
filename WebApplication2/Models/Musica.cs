using System.ComponentModel.DataAnnotations;

namespace WebApplication2.ModelsMusica
{
    public class Musica
    {
        [Key]
        public int IdMusica { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public int IdDisco{ get; set; }
    }
}