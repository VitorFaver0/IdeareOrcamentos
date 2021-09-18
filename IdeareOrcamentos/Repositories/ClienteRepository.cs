using IdeareOrcamentos.Data;
using IdeareOrcamentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeareOrcamentos.Repositories
{

    public interface IClientesRepository
    {
        void Create(Cliente cliente);
        void Save();
        void Delete(int id);
        Cliente GetById(int id);
        IQueryable<Cliente> GetAll();
    }

    public class ClienteRepository : IClientesRepository
    {
        private readonly DataContext _context;
        public ClienteRepository(DataContext context)
        {
            _context = context;
        }
        public void Create(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            Cliente cliente = _context.Clientes.Find(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
            }
        }

        public Cliente GetById(int id)
        {
            return _context.Clientes.Find(id);
        }

        public IQueryable<Cliente> GetAll()
        {
            return _context.Set<Cliente>().AsNoTracking();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
