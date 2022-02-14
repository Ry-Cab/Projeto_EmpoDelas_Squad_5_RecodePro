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
        public int Id_autonoma { get; set; }

        [StringLength(75)]
        [Required(ErrorMessage = "Por favor, digite o seu nome.")]
        public string Nome_autonoma { get; set; }

        [StringLength(75)]
        [Required(ErrorMessage = "Por favor, digite o seu sobrenome.")]
        public string Sobrenome_autonoma { get; set; }

        [StringLength(75)]
        [Required(ErrorMessage = "Por favor, digite o seu melhor E-mail.")]
        public string Email_autonoma { get; set; }

        [StringLength(15)]
        [Required(ErrorMessage = "Por favor, digite a sua data de nascimento.")]
        public string DataNasc_autonoma { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "Por favor, digite o seu número de contato.")]
        public string NumTelefone_autonoma { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Por favor, digite o seu enndereço.")]
        public string Endereco_autonoma { get; set; }

        [StringLength(9)]
        [Required(ErrorMessage = "Por favor, digite o seu CEP.")]
        public string Cep_autonoma { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Por favor, digite o nome do seu negócio.")]
        public string NomeNegocio_autonoma { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "Por favor, digite o número de contato do seu negócio.")]
        public string ContatoNegocio_autonoma { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "Por favor, digite a categoria do seu negócio.")]
        public string CategoriaNegocio_autonoma { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Por favor, descreva o seu negócio.")]
        public string DescricaoNegocio_autonoma { get; set; }

        public string ComprovanteResid_autonoma { get; set; }
    }
}
