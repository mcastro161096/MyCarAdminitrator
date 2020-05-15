using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AppWeb.Models
{
    public class PessoaDocumentos
    {
        [ForeignKey("Pessoa")]
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        [MaxLength(11)]
        public string Cpf { get; set; }
        [MaxLength(14)]
        public string Cnpj { get; set; }
        [MaxLength(10)]
        public string Rg { get; set; }
        [MaxLength(9)]
        public string Sexo { get; set; }
        [MaxLength(10)]
        public string EstadoCivil { get; set; }

    }
}