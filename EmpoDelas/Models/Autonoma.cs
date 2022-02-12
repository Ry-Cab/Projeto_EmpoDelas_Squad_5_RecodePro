using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace empodelas.Models
{
    public class Autonoma
    {
        [Key]
        public int id_autonoma { get; set; }

        [StringLength(75)]
        [Required(ErrorMessage = "Digite o seu nome")]
        public string nome_autonoma { get; set; }

        [StringLength(75)]
        [Required(ErrorMessage = "Digite o seu sobrenome")]
        public string sobrenome_autonoma { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Digite o seu melhor E-mail")]
        public string email_autonoma { get; set; }

        [StringLength(9)]
        [Required(ErrorMessage = "Digite uma senha")]
        public string senha_autonoma { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "Digite o seu número de contato")]
        public string telefone_autonoma { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Digite o nome do seu negócio")]
        public string nomeNegocio_autonoma { get; set; }
    }
}
