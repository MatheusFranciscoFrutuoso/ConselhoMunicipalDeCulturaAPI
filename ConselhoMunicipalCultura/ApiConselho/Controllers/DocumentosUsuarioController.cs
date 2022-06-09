using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ApiConselho.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentosUsuarioController : Controller
    {
        private readonly Servico _service;

        public DocumentosUsuarioController(Servico service)
        {
            _service = service;
        }
        [HttpGet("GetDocumentoUsuarioById")]
        public async Task<ActionResult> GetDocumentoUsuarioById(int id, CancellationToken token)
        {
            var result = await _service.getDocumentoUsuarioById(id, token);
            return Ok(result);
        }
        [HttpGet("GetAllDocumentosUsuarios")]
        public async Task<ActionResult> GetAllDocumentosUsuarios(CancellationToken token)
        {
            var result = await _service.getAllDocumentosUsuarios(token);
            return Ok(result);
        }
        [HttpPost("PostDocumentoUsuario")]
        public async Task<ActionResult> PostDocumentoUsuario(DocumentosUsuarios model, CancellationToken token)
        {
            var result = await _service.postDocumentosUsuarios(model, token);
            return Ok(result);
        }
        [HttpDelete("DeleteDocumentoUsuario")]
        public async Task<ActionResult> DeleteDocumentoUsuario(int id, CancellationToken token)
        {
            var result = await _service.deleteDocumentosUsuarios(id, token);
            return Ok(result);
        }
        [HttpPut("UpdateDocumentoUsuario")]
        public async Task<ActionResult> UpdateDocumentoUsuario(DocumentosUsuarios model, CancellationToken token)
        {
            var result = await _service.updateDocumentosUsuarios(model, token);
            return Ok(result);
        }
    }
}
