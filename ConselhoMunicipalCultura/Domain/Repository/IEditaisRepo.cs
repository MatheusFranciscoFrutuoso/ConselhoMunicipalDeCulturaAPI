using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IEditaisRepo
    {
        Task<Editais> GetById(int id, CancellationToken token);
        Task<List<Editais>> GetAll(CancellationToken token);
        Task<int> Create(Editais model, CancellationToken token);
        Task<int> DeleteById(Editais model, CancellationToken token);
        Task<int> UpdateById(Editais model, CancellationToken token);
    }
}
