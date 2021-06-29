using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DragonBall.Models {
    public class Usuario {
        [Key]
        public  int UserId { get; set; }
        public  string UserName { get; set; }
        public string Senha { get; set; }
    
    }
}
