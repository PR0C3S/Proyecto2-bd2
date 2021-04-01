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
        private long idDueno;
        private float calificacion=0;
        public static int votantes=0;
        private int precio;
        private String servicios;
        private int capacidad;
        private bool ninos;
        private bool mascotas;
        private bool fumar;
        private List<Reserva> reservas;


        public Publicacion(String titulo, Image imagen, long idDueno, int precio, String servicios, int capacidad, bool ninos, bool mascotas, bool fumar)
        {
            this.Titulo = titulo;
            this.idPublicacion = idPublicacion++;
            this.foto = imagen;
            this.idDueno = idDueno;
            this.precio = precio;
            this.servicios = servicios;
            this.capacidad = capacidad;
            this.ninos = ninos;
            this.mascotas = mascotas;
            this.fumar = fumar;
            
        }



    }
}
