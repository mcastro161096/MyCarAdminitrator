using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyCarAdministrator.Models
{
    public enum TipoDePessoa
    {
        [Display(Name ="Física")]
        Fisica, 
        [Display(Name ="Jurídica")]
        Juridica
    }
}