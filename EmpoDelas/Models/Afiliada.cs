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
        public int Id_afiliada { get; set; }

        [StringLength(75)]
        [Required(ErrorMessage = "Por favor, digite o seu nome.")]
        public string Nome_afiliada { get; set; }

        [StringLength(75)]
        [Required(ErrorMessage = "Por favor, digite o seu sobrenome.")]
        public string Sobrenome_afiliada { get; set; }

        [StringLength(75)]
        [Required(ErrorMessage = "Por favor, digite o seu melhor E-mail.")]
        public string Email_afiliada { get; set; }

        [StringLength(15)]
        [Required(ErrorMessage = "Por favor, digite a sua data de nascimento.")]
        public string DataNasc_afiliada { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "Por favor, digite o seu número de contato.")]
        public string NumTelefone_afiliada { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Por favor, digite o seu enndereço.")]
        public string Endereco_afiliada { get; set; }

        [StringLength(9)]
        [Required(ErrorMessage = "Por favor, digite o seu CEP.")]
        public string Cep_afiliada { get; set; }

        [StringLength(255)]
        public string Descricao_afiliada { get; set; }

        public string ComprovanteResid_afiliada { get; set; }


    }
}

