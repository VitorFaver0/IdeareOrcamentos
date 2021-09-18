using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeareOrcamentos.Models
{
    public class ListaMateriaisOrcamento
    {
        [Key]
        public int ID { get; set; }
        public int ID_Orcamento { get; set; }
        public int ID_Material { get; set; }
        public int Quantidade { get; set; }

        [ForeignKey("ID_Material")]
        public virtual Material Material { get; set; }
        [ForeignKey("ID_Orcamento")]
        public virtual Orcamento Orcamento { get; set; }
    }
}
