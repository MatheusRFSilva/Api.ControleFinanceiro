
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.ControleFinanceiro.Data;
using Api.ControleFinanceiro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.ControleFinanceiro.Controllers
{
    [ApiController]
    [Route("api/v1/usuarios")]
    public class UsuarioController : ControllerBase
    {
        private DataContext _context;

        public UsuarioController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Usuario>>> Get(
            [FromServices] DataContext context
        )
        {
            var usuarios = await context.Usuarios
            .AsNoTracking()
            .ToListAsync();
            return usuarios;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Usuario>> Post(
            [FromServices] DataContext context,
            [FromBody] Usuario model
        )
        {
            if (ModelState.IsValid)
            {
                context.Usuarios.Add(model);
                await context.SaveChangesAsync();
                var conta = new Conta { UsuarioId = model.Id };
                context.Contas.Add(conta);
                await context.SaveChangesAsync();

                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

    }
}