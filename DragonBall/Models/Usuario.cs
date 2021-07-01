using System.ComponentModel.DataAnnotations;

namespace DragonBall.Models {
    public class Usuario {
        [Key]
        public  int UserId { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public  string UserName { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Senha { get; set; }
        public string Role { get; set; }

    }
}
