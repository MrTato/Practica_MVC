using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practica_MVC.Models;
using WebGrease.Configuration;

namespace Practica_MVC.Controllers

{
    public class EmpleadoController : Controller
    {
        List<EmpleadoCLS> listaEmpleado = null;
        String connectionString = "Data Source=.;Initial Catalog=MANTENIMIENTO;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
        // GET: Empleado
        public ActionResult Index()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                listaEmpleado = new List<EmpleadoCLS>();

                SqlCommand cmd = new SqlCommand("dbo.tabla_Empleado", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    EmpleadoCLS empleado = new EmpleadoCLS();

                    empleado.id_empleado = (int)dr["id_empleado"];
                    empleado.nombre = dr["nombre"].ToString();
                    empleado.salario_por_hora = (float)(Decimal)dr["salario_por_hora"];

                    listaEmpleado.Add(empleado);
                }

                return View(listaEmpleado);
            }

            /*using (var database = new MANTENIMIENTOEntities())
            {

                listaEmpleado = (from E in database.tabla_Empleado()
                                 select new EmpleadoCLS
                                 {
                                     id_empleado = E.id_empleado,
                                     salario_por_hora = (float)E.salario_por_hora,
                                     nombre = E.nombre
                                 }).ToList();
            }
            return View(listaEmpleado);*/
        }
    }
}