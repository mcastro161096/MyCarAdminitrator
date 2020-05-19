using MyCarAdministrator.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCarAdministrator
{
   public class AppContext : DbContext
    {
        public AppContext() : base("name=DbAppweb")
        {
            Database.SetInitializer<AppContext>(new CreateDatabaseIfNotExists<AppContext>());
        }
        public  DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<PessoaContato> PessoaContatos { get; set; }

        public DbSet<PessoaDocumento> PessoaDocumentos { get; set; }

        public DbSet<PessoaEndereco> PessoaEndereco { get; set; }

        public DbSet<PessoaPapel> PessoaPapel { get; set; }

        public DbSet<ServicoPrestado> ServicosPrestados { get; set; }

        public DbSet<Veiculo> Veiculos { get; set; }

        public DbSet<TipoDeServico> TiposDeServicos { get; set; }




    }
}
