using Domain.Entities;
using Domain.Repository;
using Infra.Context;
using Infra.Repository.BaseRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Infra.Repository.TemaRepository
{
    public class TemaRepo : BaseRepo<Tema>, ITemaRepo
    {
        public TemaRepo(PostgresContext context) : base(context) { }

        public async Task<Tema> GetById(int id, CancellationToken token)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Id == id, token);
        }

        public Task<int> Create(Tema model, CancellationToken token)
        {
            _dbSet.Add(model);
            return _context.SaveChangesAsync(token);
        }

        public Task<int> DeleteById(Tema model, CancellationToken token)
        {
            _dbSet.Remove(model);
            return _context.SaveChangesAsync(token);
        }

        public Task<List<Tema>> GetAll(CancellationToken token)
        {
            return _dbSet.ToListAsync(token);
        }

        public Task<int> UpdateById(Tema model, CancellationToken token)
        {
            _dbSet.Update(model);
            return _context.SaveChangesAsync(token);
        }
    }
}
