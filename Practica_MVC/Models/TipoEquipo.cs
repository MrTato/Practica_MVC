using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practica_MVC.Models
{
    public class TipoEquipo
    {
        [Display(Name = "Tipo Equipo")]
       public String tipo_equipo { get; set; }
        [Display(Name = "Medida")]
        public String medida { get; set; }
    }
}