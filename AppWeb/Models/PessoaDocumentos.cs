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
        [Key]
        public int IdDocumento { get; set; }

        [ForeignKey("Pessoa")]
        public int PessoaId { get; set; }

        public virtual Pessoa Pessoa { get; set; }

        [Display(Name = "CPF")]
        [MaxLength(11)]
        public string Cpf { get; set; }

        [Display(Name = "CNPJ")]
        [MaxLength(14)]
        public string Cnpj { get; set; }

        [Display(Name = "RG")]
        [MaxLength(10)]
        public string Rg { get; set; }

        [MaxLength(9)]
        public string Sexo { get; set; }

        [Display(Name = "Estado Civíl")]
        [MaxLength(10)]
        public string EstadoCivil { get; set; }

        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        public DateTime Dataatualizacao { get; set; }


    }
}