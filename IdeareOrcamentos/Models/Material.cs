using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IdeareOrcamentos.Models
{
    public class Material
    {
        [Key]
        public int ID_Material { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public string Fornecedor { get; set; }
        public decimal Valor { get; set; }
    }
}
