using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repository.BaseRepository
{
    public class BaseRepo<T> where T : Base
    {
        protected readonly DbContext _context;
        protected readonly DbSet<T> _dbSet;

        public BaseRepo(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
    }
}
