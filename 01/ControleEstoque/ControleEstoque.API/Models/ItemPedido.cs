using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleEstoque.API.Models
{
    public class ItemPedido
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Quantidade { get; set; }

        [Required, Column(TypeName = "decimal(10,2)")]
        public decimal PrecoUnitario { get; set; }
    }
}
