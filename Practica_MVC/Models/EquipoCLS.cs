using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practica_MVC.Models
{
    public class EquipoCLS
    {
        [Display(Name="Equipo")]
        public string Equipo { get; set; }

        [Display(Name = "Tipo de equipo")]
        public string Tipo_equipo { get; set; }

        [Display(Name = "Marca")]
        public string Marca { get; set; }


    }
}