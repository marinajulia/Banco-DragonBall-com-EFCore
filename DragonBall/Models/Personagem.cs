using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DragonBall.Models
{
    public class Personagem
    {
        [Key]
        public int PersonagemId { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(100, ErrorMessage = "Este compo deve conter entre 1 e 100 caracteres")]
        [MinLength(1, ErrorMessage = "Este campo deve conter entre 1 e 100 caracteres")]
        public string Nome { get; set; }

        // [Required(ErrorMessage = "Este campo é obrigatório")]
        // [MaxLength(10000, ErrorMessage = "Este campo deve conter entre 1 e 10000 caracteres")]
        // [MinLength(1, ErrorMessage = "Este campo deve conter entre 1 e 10000 caracteres")]


        [Display(Name = "Power Level", Description = "O valor deve estar entre 1 e Infinito")]
        [Range(1, int.MaxValue)]
        public int PowerLevel { get; set; }

        public int RacaId { get; set; }

        public Raca Raca { get; set; }

        public int ClasseId { get; set; }

        public Classe Classe { get; set; }



    }
}
