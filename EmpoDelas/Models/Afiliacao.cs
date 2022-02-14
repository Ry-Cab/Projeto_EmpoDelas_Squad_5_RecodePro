using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace empodelas.Models
{
    public class Afiliacao
    {
        [Key]
        public int Id_afiliacao { get; set; }

        [Required(ErrorMessage = "Por favor, insira o código do produto ou serviço cadastrado.")]
        [StringLength(10)]
        public string Codigo_produtoServico { get; set; }

        [StringLength(255)]
        public string Descricao_afiliacao { get; set; }

        public int FK_id_afiliada { get; set; }
        public virtual Afiliada Afiliada { get; set; }

        public int FK_id_produtoServico { get; set; }
        public virtual ProdutoServico ProdutoServico { get; set; }
    }
}
