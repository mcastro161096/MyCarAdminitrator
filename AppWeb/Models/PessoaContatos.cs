using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AppWeb.Models
{
    public class PessoaContatos
    {
        [Key]
        public int IdContato { get; set; }
        [ForeignKey("Pessoa")]
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        [MaxLength(8)]
        public string TipoContato { get; set; }
        [MaxLength(100)]
        public string Contato { get; set; }
    }
}