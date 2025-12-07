namespace Novedades_HP3C.Models
{
    public class Empleados
    {
        public int idEmpleado { get; set; }
        public string cuil {  get; set; }
        public string dni { get; set; }
        public int numeroLegajo { get; set; }
        public string nombreCompleto { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public int edad {  get; set; }
        public DateTime fechaIngreso { get; set; }
        public DateTime fechaFinPrueba { get; set; }
        public DateTime fechaEgreso { get; set; }
        public string area {  get; set; }
        public string categoria { get; set; }
        public string servicio {  get; set; }
        public string correoElectronico { get; set; }
        public string telefono { get; set; }
        public string empleadoAntecesor { get; set; }
        public decimal antiguedad { get; set; }
        public int regimen { get; set; }
        public decimal horasDiarias { get; set; }
        public string convenio { get; set; }
        public string rolSistema { get; set; }
    }
}
