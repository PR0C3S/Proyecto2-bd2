using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2_bd2
{
    class Alojamiento
    {
        private long idAlojamiento;
        private String provincia;
        private String tipo;
        private int habitaciones;
        private int banos;
        private int camas;


        public Alojamiento(int banos, String provincia, int habitaciones, String tipo, int camas)
        {
            this.banos = banos;
            this.idAlojamiento = idAlojamiento++;
            this.provincia = provincia;
            this.habitaciones = habitaciones;
            this.tipo = tipo;
            this.camas = camas;
        }
        
    }
}
