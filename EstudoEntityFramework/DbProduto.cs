using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoEntityFramework
{
    public class DbProduto : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
    }
}
