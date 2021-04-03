using Proyecto2_bd2.Logico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto2_bd2
{
    public partial class Form1 : Form
    {
        Persona login;
        int indiceActual;
        Publicacion [] todasRecomendada;
        Publicacion[] misPublicaciones;

        public Form1()
        {
            InitializeComponent();
            botonesFondo(2);
        }

        private void label3_Click(object sender, EventArgs e)
        {
                    }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            PanelPublicacion.Show();
            PanelVistaPublicacion.Hide();

        }

        private void btnVerMas1_Click(object sender, EventArgs e)
        {
            botonesFondo(4);
        }

        void loadPublicacion(bool valor)
        {
            
            lblPublicadoPor.Hide();
            txtPublicado.Hide();
           /* btnReservar.Show();
            btnGuardar.Hide();*/
           /* btnFoto.Hide();*/
           
            if (valor)
            {
                txtPublicado.Text = publicacion1.Persona.Nombre;
                txtTituloPublicar.Text = publicacion1.Titulo1;
                cmbProvincia.Text = publicacion1.Alojamiento.Provincia;
                cmbTipo.Text = publicacion1.Alojamiento.Tipo;
                spnHabitaciones.Value = publicacion1.Alojamiento.Habitaciones;
                spnCapacidad.Value = publicacion1.Capacidad;
                spnCamas.Value = publicacion1.Alojamiento.Camas;
                spnBanos.Value = publicacion1.Alojamiento.Banos;
            }
            else
            {
                txtPublicado.Text = "Robert Dominguez";
                txtTituloPublicar.Text = "Jarabaco, La Vega";
                cmbProvincia.Text = "La Vega";
                cmbTipo.Text = "Casa";
                spnHabitaciones.Value = 3;
                spnCapacidad.Value = 10;
                spnCamas.Value = 5;
                spnBanos.Value = 2;
                spnPrecio.Value = 190;

                for(int i = 0; i < chcListServicios.Items.Count; i++) {

                    chcListServicios.SetItemChecked(i, true);
                }

                for (int i = 0; i < chcListPermite.Items.Count; i++)
                {

                    chcListPermite.SetItemChecked(i, true);
                }

                /* txtPublicado.Text = publicacion2.Persona.Nombre;
                 txtTituloPublicar.Text = publicacion2.Titulo1;
                 cmbProvincia.Text = publicacion2.Alojamiento.Provincia;
                 cmbTipo.Text = publicacion2.Alojamiento.Tipo;
                 spnHabitaciones.Value = publicacion2.Alojamiento.Habitaciones;
                 spnCapacidad.Value = publicacion2.Capacidad;
                 spnCamas.Value = publicacion2.Alojamiento.Camas;
                 spnBanos.Value = publicacion2.Alojamiento.Banos;*/
            }


        }

        private void btnRating1_Click(object sender, EventArgs e)
        {
            if (btn2Panel1.Text == "Editar")
            {
                botonesFondo(6);
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //funcionalidad de editar 

            //funcionalidad guardar anuncio en la bd

            Alojamiento nuevoA = new Alojamiento(Decimal.ToInt32(spnBanos.Value), cmbProvincia.Text, Decimal.ToInt32(spnHabitaciones.Value), cmbTipo.Text, Decimal.ToInt32(spnCamas.Value));

            List<bool> servicios= new List<bool>();

            for (int i = 0; i < chcListServicios.Items.Count; i++)
            {
                if (chcListServicios.Items[i].Equals(true))
                {
                    //Alguna accion al encontrar un check seleccionado
                    servicios.Add(true);
                }
                else
                {
                    servicios.Add(false);
                }
            }

            List<bool> permite = new List<bool>();

            for (int i = 0; i < chcListPermite.Items.Count; i++)
            {
                if (chcListPermite.Items[i].Equals(true))
                {
                    //Alguna accion al encontrar un check seleccionado
                    permite.Add(true);
                }
                else
                {
                    permite.Add(false);
                }
            }
          
            //Publicacion nueva = new Publicacion(login, txtTituloPublicar.Text, pbCargarFoto.Image, Decimal.ToInt32(spnCamas.Value), servicios, Decimal.ToInt32(spnCapacidad.Value) , permite, nuevoA);
        }

        private void txtPublicado_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chcListPermite_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void spnCapacidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void spnHabitaciones_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (btnPublicar.BackColor == SystemColors.HotTrack)
            {
                PanelPublicacion.Show();
                PanelVistaPublicacion.Hide();
            }
            else
            {
                botonesFondo(2);
            }
            
        }

        private void btnVerMas2_Click(object sender, EventArgs e)
        {
            botonesFondo(5);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            botonesFondo(2);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            botonesFondo(3);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            botonesFondo(1);

        }

        public void botonesFondo(int numero)
        {
            
            if (numero ==1)
            {
                //mis publicaciones
                PanelPublicacion.Show();
                PanelVistaPublicacion.Hide();
                btnMisPublicaciones.BackColor = SystemColors.ControlDarkDark;
                btnPublicaciones.BackColor = SystemColors.HotTrack;
                btnPublicar.BackColor = SystemColors.HotTrack;

                btnTitulo.Text = "Mis Publicaciones";

                btn1Panel1.Text = "Eliminar";
                btn1Panel2.Text = "Eliminar";
                btn1Panel1.Image = Properties.Resources.cerca__1_;
                btn1Panel2.Image = Properties.Resources.cerca__1_;
                btn1Panel1.TextAlign = ContentAlignment.BottomCenter;
                btn1Panel2.TextAlign = ContentAlignment.BottomCenter;


                btn2Panel1.Text = "Editar";
                btn2Panel2.Text = "Editar";
                btn2Panel1.Image = Properties.Resources.lapiz;
                btn2Panel2.Image = Properties.Resources.lapiz;
            }
            else if (numero ==2)
            {
                //publicaciones
                PanelPublicacion.Show();
                PanelVistaPublicacion.Hide();

                btnMisPublicaciones.BackColor = SystemColors.HotTrack;
                btnPublicaciones.BackColor = SystemColors.ControlDarkDark;
                btnPublicar.BackColor = SystemColors.HotTrack;

                btnTitulo.Text = "Publicaciones recomendadas";

                btn1Panel1.TextAlign = ContentAlignment.BottomRight;
                btn1Panel2.TextAlign = ContentAlignment.BottomRight;
                btn1Panel1.Text = "200/Noche";
                btn1Panel2.Text = "190/Noche";
                btn1Panel1.Image = Properties.Resources.dolar__2_;
                btn1Panel2.Image = Properties.Resources.dolar__2_;


                btn2Panel1.Text = "4.8/5";
                btn2Panel2.Text = "4.5/5";
                btn2Panel1.Image = Properties.Resources.estrella__3_;
                btn2Panel2.Image = Properties.Resources.estrella__3_;
                
            }else if (numero ==3)
            {
                //publicar
                PanelPublicacion.Hide();
                PanelVistaPublicacion.Show();
                lblPublicadoPor.Hide();
                txtPublicado.Hide();
                btnReservar.Hide();
                btnGuardar.Show();

                btnMisPublicaciones.BackColor = SystemColors.HotTrack;
                btnPublicaciones.BackColor = SystemColors.HotTrack;
                btnPublicar.BackColor = SystemColors.ControlDarkDark;
            }else if (numero==4 || numero ==5 || numero ==6 || numero ==7)
            {
                PanelPublicacion.Hide();
                PanelVistaPublicacion.Show();
                if (numero == 6|| numero == 7)
                {
                    //editar publicacion
                    pbFoto1.Enabled = true;
                    txtPublicado.Enabled = true;
                    txtTituloPublicar.Enabled = true;
                    cmbProvincia.Enabled = true;
                    cmbTipo.Enabled = true;
                    spnHabitaciones.Enabled = true;
                    spnCapacidad.Enabled = true;
                    spnCamas.Enabled = true;
                    spnBanos.Enabled = true;
                    spnPrecio.Enabled = true;
                    chcListPermite.Enabled = true;
                    chcListServicios.Enabled = true;

                    lblPublicadoPor.Hide();
                    txtPublicado.Hide();
                    btnReservar.Hide();
                    btnGuardar.Show();
                    btnFoto.Show();

                    
                }
                if(numero ==4 || numero ==5)
                {
                    //ver publicacion
                    pbFoto1.Enabled = true;
                    txtPublicado.Enabled = false;
                    txtTituloPublicar.Enabled = false;
                    cmbProvincia.Enabled = false;
                    cmbTipo.Enabled = false;
                    spnHabitaciones.Enabled = false;
                    spnCapacidad.Enabled = false;
                    spnCamas.Enabled = false;
                    spnBanos.Enabled = false;
                    spnPrecio.Enabled = false;
                    chcListPermite.Enabled = false;
                    chcListServicios.Enabled = false;

                    lblPublicadoPor.Show();
                    txtPublicado.Show();
                    btnReservar.Show();
                    btnGuardar.Hide();
                    btnFoto.Hide();

                }

                if (numero == 6 || numero==4)
                {
                    loadPublicacion(true);
                }
                else
                {
                    loadPublicacion(false);
                }
            }
        }

        private void btn2Panel2_Click(object sender, EventArgs e)
        {
            if(btn2Panel2.Text == "Editar")
            {
                botonesFondo(7);
            }
            
        }

        private void btn1Panel2_Click(object sender, EventArgs e)
        {
            if(btn1Panel2.Text == "Eliminar")
            {
                eliminarBD(misPublicaciones[indiceActual+1]);
            }
        }

        private void btn1Panel1_Click(object sender, EventArgs e)
        {
            if (btn1Panel1.Text == "Eliminar")
            {
                eliminarBD(misPublicaciones[indiceActual]);
            }
        }

        private void eliminarBD(Publicacion actual)
        {
            //funcionalidad de eliminar
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            //funcionalidad de reservar si no es el dueno del anuncio
            if(login.Nombre != txtPublicado.Text)
            {

            }

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            
        }
    }
}
