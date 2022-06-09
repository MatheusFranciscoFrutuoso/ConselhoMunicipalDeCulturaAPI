using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface ITemaRepo
    {
        Task<Tema> GetById(int id, CancellationToken token);
        Task<List<Tema>> GetAll(CancellationToken token);
        Task<int> Create(Tema model, CancellationToken token);
        Task<int> DeleteById(Tema model, CancellationToken token);
        Task<int> UpdateById(Tema model, CancellationToken token);
    }
}
