using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoEntityFramework
{
    public class Program
    {
        static void Main(string[] args)
        {
            Produto novoProduto = new Produto()
            {
                Id = 1,
                Nome = "Arroz"
            };

            ProdutoAplicacao app = new ProdutoAplicacao();

            app.Cadastrar(novoProduto);

        }
    }
}
