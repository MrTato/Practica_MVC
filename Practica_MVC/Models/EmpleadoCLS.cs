using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practica_MVC.Models
{
    public class EmpleadoCLS
    {
        [Display(Name ="ID Empleado")]
        public int id_empleado { get; set; }
        [Display(Name = "Salario Laboral")]
        public float salario_por_hora { get; set; }

        [Display(Name = "Nombre")]
        public string nombre { get; set; }
    }
}