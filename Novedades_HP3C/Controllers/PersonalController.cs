using Novedades_HP3C.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Novedades_HP3C.Controllers
{
    public class PersonalController : Controller
    {
        private readonly string cadenaSQL;

        public PersonalController(IConfiguration config)
        {
            cadenaSQL = config.GetConnectionString("CadenaSQL");
        }

        public IActionResult Personal()
        {
            return View();
        }
        public IActionResult Calendario()
        {
            return View();
        }

        [HttpGet]
        public JsonResult ListaEmpleados()
        {
            List<Empleados> lista = new List<Empleados>();

            using (var conexion = new SqlConnection(cadenaSQL))
            {
                conexion.Open();
                var cmd = new SqlCommand("SP_LISTA_EMPLEADOS", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Empleados
                        {
                            numeroLegajo = Convert.ToInt32(dr["numero_legajo"]),
                            nombreCompleto = dr["nombre_completo"].ToString(),
                            dni = dr["dni"].ToString(),
                            cuil = dr["cuil"].ToString(),
                            fechaIngreso = Convert.ToDateTime(dr["fecha_ingreso"]),
                            antiguedad = Convert.ToDecimal(dr["antiguedad"]),
                            area = dr["area"].ToString(),
                            categoria = dr["categoria"].ToString(),
                            servicio = dr["servicio"].ToString(),
                            regimen = Convert.ToInt32(dr["regimen"]),
                            horasDiarias = Convert.ToDecimal(dr["horas_diarias"]),
                            convenio = dr["convenio"].ToString(),
                            telefono = dr["telefono"].ToString()
                        });
                    }
                }
            }
            return Json(new { data = lista });
        }
    }
}
