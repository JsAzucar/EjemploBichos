using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bichos
{
    public class Persona
    {
        public Persona()
        { }
             public int Id { get; set; }
             public string Nombre { get; set; } = "";
             public string Apellido { get; set; } = "";
             public DateTime? FechaNacimiento { get; set; }   // puede ser null si no la conoces
             public string Email { get; set; } = "remoto@bichos.sv";
             public string Telefono { get; set; } = "9999-9999";
             public string Direccion { get; set; } = "";


    
        }
}
