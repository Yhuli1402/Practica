using System.ComponentModel.DataAnnotations;

namespace WebApplication2.ModelsDisco
{
    public class Disco
    {
        [Key]
        public int IdDisco { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Año { get; set; }

    }
}