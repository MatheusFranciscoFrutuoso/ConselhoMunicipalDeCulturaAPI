using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IDocumentosUsuarioRepo
    {
        Task<DocumentosUsuarios> GetById(int id, CancellationToken token);
        Task<List<DocumentosUsuarios>> GetAll(CancellationToken token);
        Task<int> Create(DocumentosUsuarios model, CancellationToken token);
        Task<int> DeleteById(DocumentosUsuarios model, CancellationToken token);
        Task<int> UpdateById(DocumentosUsuarios model, CancellationToken token);
    }
}
