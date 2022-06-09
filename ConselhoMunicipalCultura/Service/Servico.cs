using Domain.Entities;
using Domain.Repository;
using Infra.Repository.UsuarioRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Service
{
    public class Servico
    {
        private readonly IUsuarioRepo _usuarioRepository;
        private readonly ITemaRepo _temaRepository;
        private readonly IDocumentosUsuarioRepo _documentosUsuariosRepository;
        private readonly IEditaisRepo _editaisRepository;

        public Servico(
            IUsuarioRepo usuarioRepository,
            ITemaRepo temaRepository,
            IDocumentosUsuarioRepo documentosUsuariosRepository,
            IEditaisRepo editaisRepository)
        {
            _usuarioRepository = usuarioRepository;
            _temaRepository = temaRepository;
            _documentosUsuariosRepository = documentosUsuariosRepository;
            _editaisRepository = editaisRepository;
        }

        #region Usuario
        public Task<Usuario> getUserById(int id, CancellationToken token)
        {
            return _usuarioRepository.GetById(id, token);
        }
        public Task<List<Usuario>> getAllUsers(CancellationToken token)
        {
            return _usuarioRepository.GetAll(token);
        }
        public Task<int> postUser(Usuario model, CancellationToken token)
        {
            return _usuarioRepository.Create(model, token);
        }
        public async Task<int> deleteUser(int id, CancellationToken token)
        {
            var modelDeletar = await getUserById(id, token);
            return await _usuarioRepository.DeleteById(modelDeletar, token);
        }
        public Task<int> updateUser(Usuario model, CancellationToken token)
        {
            return _usuarioRepository.UpdateById(model, token);
        }
        #endregion
        #region Tema
        public Task<Tema> getTemaById(int id, CancellationToken token)
        {
            return _temaRepository.GetById(id, token);
        }
        public Task<List<Tema>> getAllTemas(CancellationToken token)
        {
            return _temaRepository.GetAll(token);
        }
        public Task<int> postTema(Tema model, CancellationToken token)
        {
            return _temaRepository.Create(model, token);
        }
        public async Task<int> deleteTema(int id, CancellationToken token)
        {
            var modelDeletar = await getTemaById(id, token);
            return await _temaRepository.DeleteById(modelDeletar, token);
        }
        public Task<int> updateTema(Tema model, CancellationToken token)
        {
            return _temaRepository.UpdateById(model, token);
        }
        #endregion
        #region Edital
        public Task<Editais> getEditalById(int id, CancellationToken token)
        {
            return _editaisRepository.GetById(id, token);
        }
        public Task<List<Editais>> getAllEditais(CancellationToken token)
        {
            return _editaisRepository.GetAll(token);
        }
        public Task<int> postEdital(Editais model, CancellationToken token)
        {
            return _editaisRepository.Create(model, token);
        }
        public async Task<int> deleteEdital(int id, CancellationToken token)
        {
            var modelDeletar = await getEditalById(id, token);
            return await _editaisRepository.DeleteById(modelDeletar, token);
        }
        public Task<int> updateEdital(Editais model, CancellationToken token)
        {
            return _editaisRepository.UpdateById(model, token);
        }
        #endregion
        #region Usuario
        public Task<DocumentosUsuarios> getDocumentoUsuarioById(int id, CancellationToken token)
        {
            return _documentosUsuariosRepository.GetById(id, token);
        }
        public Task<List<DocumentosUsuarios>> getAllDocumentosUsuarios(CancellationToken token)
        {
            return _documentosUsuariosRepository.GetAll(token);
        }
        public Task<int> postDocumentosUsuarios(DocumentosUsuarios model, CancellationToken token)
        {
            return _documentosUsuariosRepository.Create(model, token);
        }
        public async Task<int> deleteDocumentosUsuarios(int id, CancellationToken token)
        {
            var modelDeletar = await getDocumentoUsuarioById(id, token);
            return await _documentosUsuariosRepository.DeleteById(modelDeletar, token);
        }
        public Task<int> updateDocumentosUsuarios(DocumentosUsuarios model, CancellationToken token)
        {
            return _documentosUsuariosRepository.UpdateById(model, token);
        }
        #endregion
    }
}
