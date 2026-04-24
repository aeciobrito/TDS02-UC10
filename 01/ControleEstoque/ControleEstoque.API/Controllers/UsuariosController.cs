using ControleEstoque.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControleEstoque.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioService _service;

        public UsuariosController(IUsuarioService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() 
            => Ok(await _service.ListarTodosUsuariosAsync());
    }
}
