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
    [Route("api/v1/lista")]
    public class ListaController : ControllerBase {

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Lista>>> Get([FromServices] DataContext context) {
            var lista = await context.Lista.ToListAsync();
            return lista;
        }



        [HttpPost]
        [Route("")]
        public async Task<ActionResult<int>> Post([FromServices] DataContext context, [FromBody] Lista lista) {
            if (ModelState.IsValid) {
                context.Lista.Add(lista);
                await context.SaveChangesAsync();
                return StatusCodes.Status201Created;
            } else {
                return BadRequest(ModelState);
            }
        }



        [HttpPut]
        [Route("")]
        public async Task<ActionResult<int>> Put([FromServices] DataContext context, [FromBody] Lista lista) {
            if (ModelState.IsValid) {
                context.Lista.Update(lista);
                await context.SaveChangesAsync();
                return StatusCodes.Status200OK;
            } else {
                return BadRequest(ModelState);
            }
        }



        [HttpDelete]
        [Route("")]
        public async Task<ActionResult<int>> Delete([FromServices] DataContext context, [FromBody] Lista lista) {
            if (ModelState.IsValid) {
                context.Lista.Remove(lista);
                await context.SaveChangesAsync();
                return StatusCodes.Status200OK;
            } else {
                return BadRequest(ModelState);
            }
        }
    }


}
