﻿using IdeareOrcamentos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeareOrcamentos.Data
{
   
    public class DataContext : DbContext
    {

        public DataContext()
        : base("IdeareOrcamentosContext")
        {
        }

        
        public DbSet<Material> Materiais { get; set; }

        public void Save()
        {
            base.SaveChanges();
        }
    }
}