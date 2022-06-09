using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IUsuarioRepo
    {
        Task<Usuario> GetById(int id, CancellationToken token);
        Task<List<Usuario>> GetAll(CancellationToken token);
        Task<int> Create(Usuario model, CancellationToken token);
        Task<int> DeleteById(Usuario model, CancellationToken token);
        Task<int> UpdateById(Usuario model, CancellationToken token);
    }
}
