using ControleEstoque.API.Models;

namespace ControleEstoque.API.DTOs
{
    public class UsuarioDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public PerfilUsuario Perfil { get; set; }

        public string? Turno { get; set; }
        public string? CPF { get; set; }
        public string? Setor { get; set; }
    }
}
