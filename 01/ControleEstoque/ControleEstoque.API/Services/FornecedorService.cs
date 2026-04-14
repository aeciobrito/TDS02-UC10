using ControleEstoque.API.DTOs;

namespace ControleEstoque.API.Services
{
    public class FornecedorService : IFornecedorService
    {
        Task IFornecedorService.AtualizarAsync(AtualizarFornecedorDto dto)
        {
            throw new NotImplementedException();
        }

        Task<FornecedorDto> IFornecedorService.CriarAsync(CriarFornecedorDto dto)
        {
            throw new NotImplementedException();
        }

        Task<FornecedorDto?> IFornecedorService.ObterPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<FornecedorDto>> IFornecedorService.ObterTodosAsync()
        {
            throw new NotImplementedException();
        }

        Task IFornecedorService.RemoverAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
