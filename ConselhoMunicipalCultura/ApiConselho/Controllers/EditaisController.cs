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
    public class EditaisController : Controller
    {
        private readonly Servico _service;

        public EditaisController(Servico service)
        {
            _service = service;
        }
        [HttpGet("GetEditalById")]
        public async Task<ActionResult> GetEditalById(int id, CancellationToken token)
        {
            var result = await _service.getEditalById(id, token);
            return Ok(result);
        }
        [HttpGet("GetAllEdital")]
        public async Task<ActionResult> GetAllEdital(CancellationToken token)
        {
            var result = await _service.getAllEditais(token);
            return Ok(result);
        }
        [HttpPost("PostEdital")]
        public async Task<ActionResult> PostEdital(Editais model, CancellationToken token)
        {
            var result = await _service.postEdital(model, token);
            return Ok(result);
        }
        [HttpDelete("DeleteEdital")]
        public async Task<ActionResult> DeleteEdital(int id, CancellationToken token)
        {
            var result = await _service.deleteEdital(id, token);
            return Ok(result);
        }
        [HttpPut("UpdateEdital")]
        public async Task<ActionResult> UpdateEdital(Editais model, CancellationToken token)
        {
            var result = await _service.updateEdital(model, token);
            return Ok(result);
        }
    }
}
