using IdeareOrcamentos.Models;
using IdeareOrcamentos.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IdeareOrcamentos.Repositories
{
    public interface IMateriaisRepository
    {
        void Create(Material material);
        void Save();
        void Delete(int id);
        Material GetById(int id);
        IQueryable<Material> GetAll();
    }

    public class MaterialRepository : IMateriaisRepository
    {
        private readonly DataContext _context;
        public MaterialRepository(DataContext context)
        {
            _context = context;
        }
        public void Create(Material material)
        {
            _context.Materiais.Add(material);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            Material material = _context.Materiais.Find(id);
            if (material != null)
            {
                _context.Materiais.Remove(material);
                _context.SaveChanges();
            }
        }

        public Material GetById(int id)
        {
            return _context.Materiais.Find(id);
        }

        public IQueryable<Material> GetAll()
        {
            return _context.Set<Material>().AsNoTracking();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    
    }
}
