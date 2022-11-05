using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Entidades;

namespace VistaExamen
{
    public partial class Tipos : Form
    {
        public Tipos()
        {
            InitializeComponent();
        }

        TiposDatos tiposDatos = new TiposDatos();
        string Operacion = string.Empty;//INCIALIZACION DE VARIABLE
        Entidades.Tipo tipo = new Entidades.Tipo();

        private async void LlenarDataGrid()
        {
            TiposdataGridView1.DataSource = await tiposDatos.DevolverTiposAsync();
        }
        private void Tipos_Load(object sender, EventArgs e)
        {
            DesabilitarControles();
            LlenarDataGrid();
        }

        private void HabilitarControles()
        {
            CodigotextBox1.Enabled = true;
            NombretextBox2.Enabled = true;

            //botones
            Guardarbutton1.Enabled = true;
            Cancelarbutton1.Enabled = true;
        }

        private void DesabilitarControles()
        {
            CodigotextBox1.Enabled = false;
            NombretextBox2.Enabled = false;

            //botones
            Guardarbutton1.Enabled = false;
            Cancelarbutton1.Enabled=false;

        }

        private void LimpiarControles()
        {
            CodigotextBox1.Clear();
            NombretextBox2.Clear();

        }

      

        private async void Guardarbutton1_Click(object sender, EventArgs e)
        {
          
            if (Operacion == "nuevo")
            {
                if (string.IsNullOrEmpty(CodigotextBox1.Text))
                {
                    errorProvider1.SetError(CodigotextBox1, "Ingrese el Codigo del servicio");
                    CodigotextBox1.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(NombretextBox2.Text))
                {
                    errorProvider1.SetError(NombretextBox2, "Ingrese la nombre del servicio");
                    NombretextBox2.Focus();
                    return;
                }


                tipo.Cod = CodigotextBox1.Text;
                tipo.Nombre = NombretextBox2.Text;

                bool inserto = await tiposDatos.InsertarNuevoTipoAsync(tipo);
                if (inserto)
                {
                    MessageBox.Show("Servicio Guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarDataGrid();
                    LimpiarControles();
                    DesabilitarControles();
                }
                else
                {
                    MessageBox.Show("Servicio No se pudo Guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void Nuevobutton1_Click(object sender, EventArgs e)
        {
            HabilitarControles();
            Operacion = "nuevo";
        }

        private void Cancelarbutton1_Click(object sender, EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();
        }
    }
}
