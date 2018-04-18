using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaVec
{
    class Persona
    {
        public string Nombre { get; set; }

        public string Telefono { get; set; }

        public string Correo { get; set; }

        public string Fecha { get; set; }

        public Persona(string Nombre, string Telefono, string correo, string Fecha)
        {
            this.Nombre = Nombre; //this: Para calificar a miembros ocultos por nombres similares
            this.Telefono = Telefono; //this: Para calificar a miembros ocultos por nombres similares
            this.Correo = correo; //this: Para calificar a miembros ocultos por nombres similares
            this.Fecha = Fecha; //this: Para calificar a miembros ocultos por nombres similares
        }

        public override string ToString()
        {
            string per = "Nombre: " + Nombre.ToString() + Environment.NewLine +
                         "Telefono: " + Telefono.ToString() + Environment.NewLine +
                         "Correo: " + Correo.ToString() + Environment.NewLine +
                         "Fecha de Nacimiento: " + Fecha.ToString() + Environment.NewLine;
                return per;
        }


    }

}
