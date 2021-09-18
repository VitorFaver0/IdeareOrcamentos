using IdeareOrcamentos.Data;
using IdeareOrcamentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeareOrcamentos.Repositories
{
    public interface IOrcamentosRepository
    {
        void Create(Orcamento orcamento);
        void Save();
        void Delete(int id);
        Orcamento GetById(int id);
        IQueryable<Orcamento> GetAll();
    }

    public class OrcamentosRepository : IOrcamentosRepository
    {
        private readonly DataContext _context;
        public OrcamentosRepository(DataContext context)
        {
            _context = context;
        }
        public void Create(Orcamento orcamento)
        {
            _context.Orcamentos.Add(orcamento);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            Orcamento orcamento = _context.Orcamentos.Find(id);
            if (orcamento != null)
            {
                _context.Orcamentos.Remove(orcamento);
                _context.SaveChanges();
            }
        }

        public Orcamento GetById(int id)
        {
            return _context.Orcamentos.Find(id);
        }

        public IQueryable<Orcamento> GetAll()
        {
            return _context.Set<Orcamento>().AsNoTracking();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
