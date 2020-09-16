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
    public class Tipo_EquipoController : Controller
    {
        List<Tipo_EquipoCLS> ListaTipoEquipo = null;
        String connectionString = "Data Source=.;Initial Catalog=MANTENIMIENTO;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
        // GET: TipoEquipo
        public ActionResult Index()
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                ListaTipoEquipo = new List<Tipo_EquipoCLS>();

                SqlCommand cmd = new SqlCommand("dbo.tabla_Tipo_Equipo", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Tipo_EquipoCLS tipo_Equipo = new Tipo_EquipoCLS();

                    tipo_Equipo.medida = dr["medida"].ToString();
                    tipo_Equipo.tipo_equipo = dr["tipo_equipo"].ToString();

                    ListaTipoEquipo.Add(tipo_Equipo);
                }

                return View(ListaTipoEquipo);
            }
        }
    }
}