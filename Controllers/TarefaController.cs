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
    [Route("api/v1/tarefa")]
    public class TarefaController : ControllerBase {

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Tarefa>>> Get([FromServices] DataContext context) {
            var tarefa = await context.Tarefa.ToListAsync();
            return tarefa;
        }



        [HttpPost]
        [Route("")]
        public async Task<ActionResult<int>> Post([FromServices] DataContext context, [FromBody] Tarefa tarefa) {
            if (ModelState.IsValid) {
                context.Tarefa.Add(tarefa);
                await context.SaveChangesAsync();
                return StatusCodes.Status201Created;
            } else {
                return BadRequest(ModelState);
            }
        }



        [HttpPut]
        [Route("")]
        public async Task<ActionResult<int>> Put([FromServices] DataContext context, [FromBody] Tarefa tarefa) {
            if (ModelState.IsValid) {
                context.Tarefa.Update(tarefa);
                await context.SaveChangesAsync();
                return StatusCodes.Status200OK;
            } else {
                return BadRequest(ModelState);
            }
        }



        [HttpDelete]
        [Route("")]
        public async Task<ActionResult<int>> Delete([FromServices] DataContext context, [FromBody] Tarefa tarefa) {
            if (ModelState.IsValid) {
                context.Tarefa.Remove(tarefa);
                await context.SaveChangesAsync();
                return StatusCodes.Status200OK;
            } else {
                return BadRequest(ModelState);
            }
        }
    }


}
