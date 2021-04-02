using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto2_bd2
{
    public partial class Form1 : Form
    {
        Publicacion publicacion1;
        Publicacion publicacion2;
        public Form1()
        {
            InitializeComponent();
            PanelPublicacion.Show();
            PanelVistaPublicacion.Hide();
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
            loadPublicacion(true);
        }

        void loadPublicacion(bool valor)
        {
            lblPublicadoPor.Show();
            txtPublicado.Show();
            btnReservar.Show();
            btnGuardar.Hide();

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
                txtPublicado.Text = publicacion2.Persona.Nombre;
                txtTituloPublicar.Text = publicacion2.Titulo1;
                cmbProvincia.Text = publicacion2.Alojamiento.Provincia;
                cmbTipo.Text = publicacion2.Alojamiento.Tipo;
                spnHabitaciones.Value = publicacion2.Alojamiento.Habitaciones;
                spnCapacidad.Value = publicacion2.Capacidad;
                spnCamas.Value = publicacion2.Alojamiento.Camas;
                spnBanos.Value = publicacion2.Alojamiento.Banos;
            }
            

        }

        private void btnRating1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


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
            PanelVistaPublicacion.Hide();
            PanelPublicacion.Show();
        }

        private void btnVerMas2_Click(object sender, EventArgs e)
        {
            loadPublicacion(false);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            PanelPublicacion.Show();
            PanelVistaPublicacion.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            PanelVistaPublicacion.Show();
            PanelPublicacion.Hide();
            lblPublicadoPor.Hide();
            txtPublicado.Hide();
            btnReservar.Hide();
            btnGuardar.Show();
        }
    }
}
