using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeareOrcamentos.Models
{
    public class Cliente
    {
        [Key]
        public int ID_Cliente { get; set; }
        public string Nome { get; set; }
        public string Numero  { get; set; }
        
    }
}
