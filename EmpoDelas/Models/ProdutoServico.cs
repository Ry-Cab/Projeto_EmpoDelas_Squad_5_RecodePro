using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace empodelas.Models
{
    public class ProdutoServico
    {
        [Key]
        public int Id_produtoServico { get; set; }

        [Required]
        [StringLength(10)]
        public string Codigo_produtoServico { get; set; }

        [Required(ErrorMessage = "Por favor, selecione se é produto ou serviço.")]
        public string Tipo_produtoServico { get; set; }

        [StringLength(60)]
        [Required(ErrorMessage = "Por favor, digite o nome do seu produto ou serviço.")]
        public string Nome_produtoServico { get; set; }

        [StringLength(255)]
        public string Descricao_produtoServico { get; set; }

        [Required(ErrorMessage = "Por favor, digite o preço do seu produto ou serviço.")]
        public decimal Preco_produtoServico { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Por favor, digite o nome do seu negócio cadastrado.")]
        public string NomeNegocio_autonoma { get; set; }

        public int FK_id_autonoma { get; set; }
        public virtual Autonoma Id_autonoma { get; set; }
    }
}

