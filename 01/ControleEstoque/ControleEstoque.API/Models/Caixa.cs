using System.ComponentModel.DataAnnotations;

namespace ControleEstoque.API.Models
{
    public class Caixa : Usuario
    {
        [StringLength(50)]
        public string Turno { get; set; }
    }
}
