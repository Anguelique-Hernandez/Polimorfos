using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demolterfaces
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string NombreCompeto => $"{Nombre} {Apellidos}";

        public Persona (string nombre,string apellidos  )
        {
            Nombre = nombre;
            Apellidos = apellidos;
        }
    }
}
