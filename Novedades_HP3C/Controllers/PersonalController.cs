using Novedades_HP3C.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

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
        public IActionResult ControlAsistencia()
        {
            return View();
        }
        public IActionResult RegistroAsistencia()
        {
            return View();
        }

        [HttpGet]
        public JsonResult ListaEmpleados()
        {
            List<Empleados> lista = new List<Empleados>();

            using (var conexion = new MySqlConnection(cadenaSQL))
            {
                conexion.Open();
                var cmd = new MySqlCommand("SP_LISTA_EMPLEADOS", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Empleados
                        {
                            numeroLegajo = Convert.ToInt32(dr["LEGAJO"]),
                            nombreCompleto = dr["NOMBRE"].ToString(),
                            dni = dr["DNI"].ToString(),
                            cuil = dr["CUIL"].ToString(),
                            fechaIngreso = Convert.ToDateTime(dr["FECHA_INGRESO"]),
                            antiguedad = Convert.ToDecimal(dr["ANTIGUEDAD"]),
                            area = dr["AREA"].ToString(),
                            categoria = dr["CATEGORIA"].ToString(),
                            servicio = dr["SERVICIO"].ToString(),
                            regimen = Convert.ToInt32(dr["REGIMEN"]),
                            horasDiarias = Convert.ToDecimal(dr["HORAS_DIARIAS"]),
                            convenio = dr["CONVENIO"].ToString(),
                            telefono = dr["TELEFONO"].ToString(),
                            estado = dr["ESTADO"].ToString()
                        });
                    }
                }
            }
            return Json(new { data = lista });
        }
    }
}
