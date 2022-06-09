using Domain.Entities;
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
        [HttpGet("GetUserById")]
        public async Task<ActionResult> GetUserById(int id, CancellationToken token)
        {
            var result = await _service.getUserById(id, token);
            return Ok(result);
        }
        [HttpGet("GetAllUsers")]
        public async Task<ActionResult> GetAllUsers(CancellationToken token)
        {
            var result = await _service.getAllUsers(token);
            return Ok(result);
        }
        [HttpPost("PostUser")]
        public async Task<ActionResult> PostUser(Usuario model, CancellationToken token)
        {
            var result = await _service.postUser(model, token);
            return Ok(result);
        }
        [HttpDelete("DeleteUser")]
        public async Task<ActionResult> DeleteUser(int id, CancellationToken token)
        {
            var result = await _service.deleteUser(id, token);
            return Ok(result);
        }
        [HttpPut("UpdateUser")]
        public async Task<ActionResult> UpdateUser(Usuario model, CancellationToken token)
        {
            var result = await _service.updateUser(model, token);
            return Ok(result);
        }
    }
}
