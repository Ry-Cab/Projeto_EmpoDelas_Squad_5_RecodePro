using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace empodelas.Models
{
    public class Afiliada
    {
        [Key]
        public int id_afiliada { get; set; }

        [StringLength(75)]
        [Required(ErrorMessage = "Digite o seu nome")]
        public string nome_afiliada { get; set; }

        [StringLength(75)]
        [Required(ErrorMessage = "Digite o seu sobrenome")]
        public string sobrenome_afiliada { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Digite o seu melhor E-mail")]
        public string email_afiliada { get; set; }

        [StringLength(9)]
        [Required(ErrorMessage = "Digite uma senha")]
        public string senha_afiliada { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "Digite o seu número de contato")]
        public string telefone_afiliada { get; set; }
    }
}

