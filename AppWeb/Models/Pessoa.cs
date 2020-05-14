using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppWeb
{
    [Table("Pessoas")]
    public class Pessoa
    {
        [Key]
        public int IdPessoa { get; set; }
        [MaxLength(150)]
        public string Nome { get; set; }
        [MaxLength(15)]
        public string Telefone { get; set; }
        [MaxLength(8)]
        public string PlacaVeiculo { get; set; }


    }
}
