using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.NTier.DataAccess.Contexts;
using TodoApp.NTier.DataAccess.Interfaces;
using TodoApp.NTier.DataAccess.Repositories;

namespace TodoApp.NTier.DataAccess.UnitofWork
{
    public class Uow : IUow
    {
        private readonly TodoContexts _context;

        public Uow(TodoContexts context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : class, new()
        {
            return new Repository<T>(_context);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
