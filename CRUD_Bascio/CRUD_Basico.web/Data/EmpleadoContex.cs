using CRUD_Basico.web.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Data;

namespace CRUD_Basico.web.Data
{
    public class EmpleadoContex : DbContext
    {
        public  DbSet<E_Empleados> Empleados { get; set; }
        public EmpleadoContex(DbContextOptions<EmpleadoContex> options) : base(options)
        {
            
        }
        
        
    }
}
