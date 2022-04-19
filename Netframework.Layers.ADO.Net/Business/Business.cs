using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;  //para usar o DataTable 

namespace Netframework.Layers.ADO.Net.Presentation
{
    internal class Business
    {
        // agregar propeiedades de la tabla//
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string FechaNacimiento { get; set; }
        public string FechaRegistro { get; set; }
        public string FechaModificacion { get; set; }
        public string FechaEliminacion { get; set; }
        public string Estado { get; set; }
    }
    
}
