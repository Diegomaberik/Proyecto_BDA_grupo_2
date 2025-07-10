using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNego
{
    public class C_Persona
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }

        public C_Persona()
        {
            Id = string.Empty;
            Nombre = string.Empty;
            Cedula = string.Empty;
            Telefono = string.Empty;
            Direccion = string.Empty;
            Correo = string.Empty;
        }

        public C_Persona(string id, string nombre, string cedula, string telefono, string direccion, string correo)
        {
            Id = id;
            Nombre = nombre;
            Cedula = cedula;
            Telefono = telefono;
            Direccion = direccion;
            Correo = correo;
        }

    }
}
