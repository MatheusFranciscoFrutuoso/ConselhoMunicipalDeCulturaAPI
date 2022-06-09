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
    public class TemaController : Controller
    {
        private readonly Servico _service;

        public TemaController(Servico service)
        {
            _service = service;
        }
        [HttpGet("GetTemaById")]
        public async Task<ActionResult> GetTemaById(int id, CancellationToken token)
        {
            var result = await _service.getTemaById(id, token);
            return Ok(result);
        }
        [HttpGet("GetAllTemas")]
        public async Task<ActionResult> GetAllTemas(CancellationToken token)
        {
            var result = await _service.getAllTemas(token);
            return Ok(result);
        }
        [HttpPost("PostTema")]
        public async Task<ActionResult> PostTema(Tema model, CancellationToken token)
        {
            var result = await _service.postTema(model, token);
            return Ok(result);
        }
        [HttpDelete("DeleteTema")]
        public async Task<ActionResult> DeleteTema(int id, CancellationToken token)
        {
            var result = await _service.deleteTema(id, token);
            return Ok(result);
        }
        [HttpPut("UpdateTema")]
        public async Task<ActionResult> UpdateTema(Tema model, CancellationToken token)
        {
            var result = await _service.updateTema(model, token);
            return Ok(result);
        }
    }
}
