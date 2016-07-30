using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoEntityFramework
{
    public class ProdutoAplicacao
    {
        public DbProduto banco { get; set; }

        public ProdutoAplicacao()
        {
            banco = new DbProduto();
        }

        public void Cadastrar(Produto produto)
        {
            banco.Produtos.Add(produto);
            banco.SaveChanges();
        }

        public IEnumerable<Produto> Listar()
        {
            return banco.Produtos.ToList();
        }

        public void Alterar(Produto produto)
        {
            Produto produtoAlterar = banco.Produtos.Where(p => p.Id == produto.Id).First();

            produtoAlterar.Nome = produto.Nome;

            banco.SaveChanges();
        }

        public void Deletar(int Id)
        {
            Produto produtoDeletar = banco.Produtos.Where(p => p.Id == Id).First();

            banco.Set<Produto>().Remove(produtoDeletar);
            banco.SaveChanges();

        }
    }
}
