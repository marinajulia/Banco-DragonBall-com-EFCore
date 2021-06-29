using System.ComponentModel.DataAnnotations;

namespace DragonBall.Models {
    public class Usuario {
        [Key]
        public  int UserId { get; set; }
        public  string UserName { get; set; }
        public string Senha { get; set; }
        public string Role { get; set; }

    }
}
