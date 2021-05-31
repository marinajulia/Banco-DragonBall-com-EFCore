using System.ComponentModel.DataAnnotations;

namespace DragonBall.Models
{
    public class InfoRaca
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(1000, ErrorMessage = "Este compo deve conter entre 1 e 1000 caracteres")]
        [MinLength(1, ErrorMessage = "Este campo deve conter entre 1 e 1000 caracteres")]
        public string DescricaoInfoRaca { get; set; }

        public int RacaId { get; set; }
        public Raca raca { get; set; }
    }
}
