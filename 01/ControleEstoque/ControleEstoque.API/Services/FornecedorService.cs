using ControleEstoque.API.Data;
using ControleEstoque.API.DTOs;
using Microsoft.EntityFrameworkCore;

namespace ControleEstoque.API.Services
{
    public class FornecedorService : IFornecedorService
    {
        #region Propriedades
        private readonly AppDbContext _context;

        public FornecedorService(AppDbContext context) 
        {
            _context = context;
        }
        #endregion

        async Task IFornecedorService.AtualizarAsync(AtualizarFornecedorDto dto)
        {
            var fornecedor = await _context.Fornecedores.FindAsync(dto.Id);
            if(fornecedor != null)
            {
                fornecedor.NomeFantasia = dto.NomeFantasia;
                _context.Fornecedores.Update(fornecedor);
                await _context.SaveChangesAsync();
            }
        }

        Task<FornecedorDto> IFornecedorService.CriarAsync(CriarFornecedorDto dto)
        {
            throw new NotImplementedException();
        }

        async Task<FornecedorDto?> IFornecedorService.ObterPorIdAsync(int id)
        {
            var fornecedorModel = await _context.Fornecedores.FirstOrDefaultAsync(f => f.Id == id);

            if (fornecedorModel == null)
                return null;

            return new FornecedorDto
            {
                Id = fornecedorModel.Id,
                NomeFantasia = fornecedorModel.NomeFantasia,
                CNPJ = fornecedorModel.CNPJ
            };
        }

        async Task<IEnumerable<FornecedorDto>> IFornecedorService.ObterTodosAsync()
        {
            return await _context.Fornecedores
                .Select(f => new FornecedorDto 
                {
                    Id = f.Id,
                    CNPJ = f.CNPJ,
                    NomeFantasia = f.NomeFantasia
                })
                .ToListAsync();
        }

        async Task IFornecedorService.RemoverAsync(int id)
        {
            var fornecedor = await _context.Fornecedores.FirstOrDefaultAsync(f => f.Id == id);

            if (fornecedor != null)
            {
                _context.Fornecedores.Remove(fornecedor);
                await _context.SaveChangesAsync();
            }
        }
    }
}
