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

namespace Infra.Repository.UsuarioRepository
{
    public class UsuarioRepo : BaseRepo<Usuario>, IUsuarioRepo
    {
        public UsuarioRepo(PostgresContext context) : base(context) { }

        public async Task<Usuario> GetById(int id, CancellationToken token)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Id == id, token);
        }

        public Task<int> Create(Usuario model, CancellationToken token)
        {
            _dbSet.Add(model);
            return _context.SaveChangesAsync(token);
        }

        public Task<int> DeleteById(Usuario model, CancellationToken token)
        {
            _dbSet.Remove(model);
            return _context.SaveChangesAsync(token);
        }

        public Task<List<Usuario>> GetAll(CancellationToken token)
        {
            return _dbSet.ToListAsync(token);
        }

        public Task<int> UpdateById(Usuario model, CancellationToken token)
        {
            _dbSet.Update(model);
            return _context.SaveChangesAsync(token);
        }
    }
}
