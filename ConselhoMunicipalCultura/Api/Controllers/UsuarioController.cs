using Microsoft.AspNetCore.Mvc;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private readonly Servico _service;

        public UsuarioController(Servico service)
        {
            _service = service;
        }
        [HttpGet("Teste")]
        public async Task<ActionResult> Teste(int id, CancellationToken token)
        {
            var result = await _service.testee(id, token);
            return Ok(result);
        }
    }
}
