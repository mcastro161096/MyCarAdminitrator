using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AppWeb.Models
{
    public class PessoaPapel
    {
        [Key]
        public int IdPapel { get; set; }

        [ForeignKey("Pessoa")]
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }


        public string Empresa { get; set; }

        public string Filial { get; set; }

        public string Papel { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public DateTime Dataatualizacao { get; set; }
    }
}