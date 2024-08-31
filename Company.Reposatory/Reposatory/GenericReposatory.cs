using Company.Reposatory.Interfaces;
using Company_Data.Context;
using Company_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Reposatory.Reposatory
{
    public class GenericReposatory<T> : IGenericReposatory<T> where T : BaseEntity
    {
        private readonly CompanyDbContext _context;

        public GenericReposatory(CompanyDbContext context)
        {
            _context = context;
        }

         void IGenericReposatory<T>.Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }
        

         void IGenericReposatory<T>.Delete(int id)
        {
            _context.Remove(id);
            _context.SaveChanges();
        }

         List<T> IGenericReposatory<T>.GetAll()
        => _context.Set<T>().ToList();

         T IGenericReposatory<T>.GetById(int id)
        => _context.Set<T>().FirstOrDefault(x=> x.Id == id);

         void IGenericReposatory<T>.Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}
