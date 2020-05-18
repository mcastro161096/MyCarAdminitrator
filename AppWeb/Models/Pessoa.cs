using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppWeb
{
    [Table("Pessoa")]
    public class Pessoa
    {
        [Key]
        public int IdPessoa { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(100)]
        public string Sobrenome { get; set; }

        [MaxLength(8)]
        public string Tipo { get; set; }

        public bool Ativo { get; set; }


        public DateTime Dataatualizacao { get; set; }

       
       



    }
}
