using IdeareOrcamentos.Data;
using IdeareOrcamentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeareOrcamentos.Repositories
{
    public interface IListaMateriaisOrcamentoRepository
    {
        void Create(ListaMateriaisOrcamento listaMateriaisOrcamento);
        void Save();
        void Delete(int id);
        ListaMateriaisOrcamento GetById(int id);
        IQueryable<ListaMateriaisOrcamento> GetAll();
    }

    public class ListaMateriaisOrcamentoRepository : IListaMateriaisOrcamentoRepository
    {
        private readonly DataContext _context;
        public ListaMateriaisOrcamentoRepository(DataContext context)
        {
            _context = context;
        }
        public void Create(ListaMateriaisOrcamento listaMateriaisOrcamento)
        {
            _context.ListaMateriaisOrcamentos.Add(listaMateriaisOrcamento);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            ListaMateriaisOrcamento listaMateriaisOrcamento = _context.ListaMateriaisOrcamentos.Find(id);
            if (listaMateriaisOrcamento != null)
            {
                _context.ListaMateriaisOrcamentos.Remove(listaMateriaisOrcamento);
                _context.SaveChanges();
            }
        }

        public ListaMateriaisOrcamento GetById(int id)
        {
            return _context.ListaMateriaisOrcamentos.Find(id);
        }

        public IQueryable<ListaMateriaisOrcamento> GetAll()
        {
            return _context.Set<ListaMateriaisOrcamento>().AsNoTracking();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

    }
}