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
    [Route("api/v1/categoria")]
    public class CategoriaController : ControllerBase {

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Categoria>>> Get([FromServices] DataContext context){
            var categoria = await context.Categoria.ToListAsync();
            return categoria;
        }



        [HttpPost]
        [Route("")]
        public async Task<ActionResult<int>> Post([FromServices] DataContext context, [FromBody] Categoria nomeCategoria){
            if (ModelState.IsValid){
                context.Categoria.Add(nomeCategoria);
                await context.SaveChangesAsync();
                return StatusCodes.Status201Created;
            }else{
                return BadRequest(ModelState);
            }
        }



        [HttpPut]
        [Route("")]
        public async Task<ActionResult<int>> Put([FromServices] DataContext context, [FromBody] Categoria categoria) {
            if (ModelState.IsValid) {
                context.Categoria.Update(categoria);
                await context.SaveChangesAsync();
                return StatusCodes.Status200OK;
            } else {
                return BadRequest(ModelState);
            }
            //throw new NotImplementedException();
        }



        [HttpDelete]
        [Route("")]
        public async Task<ActionResult<int>> Delete([FromServices] DataContext context, [FromBody] Categoria idCategoria) {
            if (ModelState.IsValid){
                context.Categoria.Remove(idCategoria);
                await context.SaveChangesAsync();
                return StatusCodes.Status200OK;
            }else{
                return BadRequest(ModelState);
            }
        }
    }


}