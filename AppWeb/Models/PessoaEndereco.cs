using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AppWeb.Models
{
    public class PessoaEndereco
    {
        [Key]
        public int IdEndereco { get; set; }

        [ForeignKey("Pessoa")]
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }

        [MaxLength(25)]
        public string Estado { get; set; }

        [MaxLength(40)]
        public string Cidade { get; set; }

        [MaxLength(100)]
        public string Rua { get; set; }

        [Display(Name = "Número")]
        [MaxLength(6)]
        public string Numero { get; set; }

        [MaxLength(10)]
        public string Cep { get; set; }

        [MaxLength(40)]
        public string Complemento { get; set; }

        public DateTime Dataatualizacao { get; set; }

    }
}