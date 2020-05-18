using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppWeb
{[Table("ServicosPrestados")]
    public class ServicoPrestado
    {
        [Key]
        public int IdServico { get; set; }

        [MaxLength(2000)]
        [Display(Name = "Descrição do serviço")]
        public string DescricaoServico { get; set; }

        [Display(Name = "Valor Total")]
        [Range(-999999999999999999.99, 999999999999999999.99)]
        public decimal ValorTotal { get; set; }

        [Display(Name = "Valor Pago")]
        [Range(-999999999999999999.99, 999999999999999999.99)]
        public decimal ValorPago { get; set; }

        [MaxLength(8)]
        public string Pago { get; set; }

        [Display(Name = "Data do Serviço")]
        public DateTime DataServico { get; set; }

        [ForeignKey("Pessoa")]
        public int PessoaId { get; set; }

        public virtual Pessoa Pessoa { get; set; }


    }
}
