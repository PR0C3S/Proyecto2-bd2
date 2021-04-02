using Proyecto2_bd2.Logico;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2_bd2
{
    class Publicacion
    {
        private Image foto;
        private long idPublicacion;
        private DateTime fecha = DateTime.Now;
        private String Titulo;
        private Persona persona;
        private float calificacion=0;
        private static int votantes = 0;
        private int precio;
        private int capacidad;
        private List<bool> servicios;
        private List<bool> permite;
        private List<Reserva> reservas = new List<Reserva>();
        private Alojamiento alojamiento;

        public Image Foto { get => foto; set => foto = value; }
        public long IdPublicacion { get => idPublicacion; set => idPublicacion = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Titulo1 { get => Titulo; set => Titulo = value; }
        internal Persona Persona { get => persona; set => persona = value; }
        public float Calificacion { get => calificacion; set => calificacion = value; }
        public static int Votantes { get => votantes; set => votantes = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
        public List<bool> Servicios { get => servicios; set => servicios = value; }
        public List<bool> Permite { get => permite; set => permite = value; }
        internal List<Reserva> Reservas { get => reservas; set => reservas = value; }
        internal Alojamiento Alojamiento { get => alojamiento; set => alojamiento = value; }

        public Publicacion(Persona persona, String titulo, Image imagen, int precio, List<bool> servicios, List<bool> permite, Alojamiento alojamiento)
        {
            this.Titulo = titulo;
            this.idPublicacion = idPublicacion++;
            this.foto = imagen;
            this.persona = persona;
            this.precio = precio;
            this.servicios = servicios;
            this.permite = permite;
            this.alojamiento = alojamiento;
        }



    }
}
