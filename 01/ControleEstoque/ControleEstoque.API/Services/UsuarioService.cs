using ControleEstoque.API.Data;
using ControleEstoque.API.DTOs;
using ControleEstoque.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleEstoque.API.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly AppDbContext _context;

        public UsuarioService(AppDbContext context)
        {
            _context = context;
        }

        public Task<UsuarioDto> BuscarUsuarioPorEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioDto> BuscarUsuarioPorId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UsuarioDto>> ListarTodosUsuariosAsync()
        {
            var usuarios = await _context.Usuarios.ToListAsync();
            return usuarios.Select(MapearParaDto);
        }

        private UsuarioDto MapearParaDto(Usuario usuario)
        {
            var dto = new UsuarioDto
            {
                Id = usuario.Id,
                Nome = usuario.Nome,
                Email = usuario.Email,
                Perfil = usuario.Perfil
            };

            return dto;
        }
    }
}
