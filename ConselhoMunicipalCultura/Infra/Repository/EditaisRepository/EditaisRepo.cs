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

namespace Infra.Repository.EditaisRepository
{
    public class EditaisRepo : BaseRepo<Editais>, IEditaisRepo
    {
        public EditaisRepo(PostgresContext context) : base(context) { }

        public async Task<Editais> GetById(int id, CancellationToken token)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Id == id, token);
        }

        public Task<int> Create(Editais model, CancellationToken token)
        {
            _dbSet.Add(model);
            return _context.SaveChangesAsync(token);
        }

        public Task<int> DeleteById(Editais model, CancellationToken token)
        {
            _dbSet.Remove(model);
            return _context.SaveChangesAsync(token);
        }

        public Task<List<Editais>> GetAll(CancellationToken token)
        {
            return _dbSet.ToListAsync(token);
        }

        public Task<int> UpdateById(Editais model, CancellationToken token)
        {
            _dbSet.Update(model);
            return _context.SaveChangesAsync(token);
        }
    }
}
