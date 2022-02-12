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
        public int id_afiliacao { get; set; }

        [Required]
        public string codigo_produtoServico { get; set; }

        public int FK_id_afiliada { get; set; }
        public virtual Afiliada Afiliada { get; set; }

        public int FK_id_produtoServico { get; set; }
        public virtual ProdutoServico ProdutoServico { get; set; }
    }
}
