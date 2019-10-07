using System;
using System.Threading.Tasks;
using DevIO.Produtos.Business.Models;

namespace DevIO.Produtos.Business.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}