using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DevIO.Produtos.Business.Models;

namespace DevIO.Produtos.Business.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<Produto> ObterProdutoFornecedor(Guid id);
        Task<IEnumerable<Produto>> ObterProdutosFornecedores();
        Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId);
    }
}