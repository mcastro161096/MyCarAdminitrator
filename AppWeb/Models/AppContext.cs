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
      public DbSet<ServicoPrestado> ServicosPrestados { get; set; }
    }
}
