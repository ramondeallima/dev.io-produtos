using System;
using System.Threading.Tasks;
using DevIO.Produtos.Business.Interfaces;
using DevIO.Produtos.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace DevIO.Produtos.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(MeuDbContext context) : base(context) { }

        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos.AsNoTracking()
                .FirstOrDefaultAsync(e => e.FornecedorId == fornecedorId);
        }
    }
}