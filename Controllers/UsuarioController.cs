using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using TodoList.Models;
using TodoList.Data;

namespace TodoList.Controllers {

    [ApiController]
    [Route("api/v1/usuario")]
    public class UsuarioController : ControllerBase {

        private readonly DataContext _context;

        public UsuarioController(DataContext context) {
            _context = context;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Usuario>>> Get() {
            List<Usuario> usuario = await _context.Usuario.ToListAsync();
            return usuario;
        }



        [HttpPost]
        [Route("")]
        public async Task<ActionResult<int>> Post([FromBody] Usuario usuario) {
            if (ModelState.IsValid) {
                _context.Usuario.Add(usuario);
                await _context.SaveChangesAsync();
                return StatusCodes.Status201Created;
            } else {
                return BadRequest(ModelState);
            }
        }



        [HttpPut]
        [Route("")]
        public async Task<ActionResult<int>> Put([FromBody] Usuario usuario) {
            if (ModelState.IsValid) {
                _context.Usuario.Update(usuario);
                await _context.SaveChangesAsync();
                return StatusCodes.Status200OK;
            } else {
                return BadRequest(ModelState);
            }
        }



        [HttpDelete]
        [Route("")]
        public async Task<ActionResult<int>> Delete([FromBody] Usuario usuario) {
            if (ModelState.IsValid) {
                _context.Usuario.Remove(usuario);
                await _context.SaveChangesAsync();
                return StatusCodes.Status200OK;
            } else {
                return BadRequest(ModelState);
            }
        }
    }


}