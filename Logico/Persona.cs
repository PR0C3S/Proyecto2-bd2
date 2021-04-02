using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2_bd2.Logico
{
    class Persona
    {
        private long idPersona;
        private String nombre;
        private List<Publicacion> publicaciones = new List<Publicacion>();
        private List<Publicacion> recomendaciones = new List<Publicacion>();
        private List<Reserva> reservaciones = new List<Reserva>();


        public Persona(String nombre)
        {
            this.nombre = nombre;
        }

        public long IdPersona { get => idPersona; set => idPersona = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        internal List<Publicacion> Publicaciones { get => publicaciones; set => publicaciones = value; }
        internal List<Publicacion> Recomendaciones { get => recomendaciones; set => recomendaciones = value; }
        internal List<Reserva> Reservaciones { get => reservaciones; set => reservaciones = value; }
    }
}
