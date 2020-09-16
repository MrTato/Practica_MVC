using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practica_MVC.Models;
namespace Practica_MVC.Controllers
{
    public class EquipoController : Controller
    {
        // GET: Equipo
        List<EquipoCLS> listaEquipo = null;
        String connectionString = "Data Source=.;Initial Catalog=MANTENIMIENTO;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
        public ActionResult Index()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                listaEquipo = new List<EquipoCLS>();

                SqlCommand cmd = new SqlCommand("dbo.tabla_Equipo", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    EquipoCLS equipo = new EquipoCLS();

                    equipo.Equipo = dr["equipo"].ToString();
                    equipo.Marca = dr["marca"].ToString();
                    equipo.Tipo_equipo = dr["tipo_Equipo"].ToString();

                    listaEquipo.Add(equipo);
                }

                return View(listaEquipo);
            }
        }
    }
}