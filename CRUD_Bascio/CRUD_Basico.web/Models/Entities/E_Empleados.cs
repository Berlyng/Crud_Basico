using System.ComponentModel.DataAnnotations;

namespace CRUD_Basico.web.Models.Entities
{
    public class E_Empleados
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
        public string Posicion { get; set; }
        public decimal Sueldo { get; set; }
        public bool Activo { get; set; }
    }
}
