using ControleEstoque.API.DTOs;

namespace ControleEstoque.API.Services
{
    public interface IUsuarioService
    {
        Task<IEnumerable<UsuarioDto>> ListarTodosUsuariosAsync();
        Task<UsuarioDto> BuscarUsuarioPorId(int id);
        Task<UsuarioDto> BuscarUsuarioPorEmail(string email);
    }
}
