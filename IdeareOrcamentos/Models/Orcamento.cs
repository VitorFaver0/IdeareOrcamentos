using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeareOrcamentos.Models
{
    public class Orcamento
    {
        [Key]
        public int ID_Orcamento { get; set; }
        public int NomeProjeto { get; set; }
        public decimal ValorProjeto { get; set; }
        public int ID_Cliente { get; set; }
        
        [ForeignKey("ID_Cliente")]
        public virtual Cliente Cliente { get; set; }

    }
}
