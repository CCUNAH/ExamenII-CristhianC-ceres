using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaExamen
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        //CREACION DE OBJEOS CON CLASES
        UsuarioDatos DatosUsuario = new UsuarioDatos();
        string Operacion = string.Empty;//INCIALIZACION DE VARIABLE
        Entidades.Usuario user = new Entidades.Usuario();


        private void HabilitarControles()
        {
            CodigotextBox1.Enabled = true;
            NombretextBox2.Enabled = true;
            EmailtextBox3.Enabled = true;
            ClavetextBox4.Enabled = true;
            //botones
            Guardarbutton3.Enabled = true;
            Cancelarbutton4.Enabled = true;
            Nuevobutton1.Enabled = false;
            Modificarbutton2.Enabled = false;
            Eliminarbutton5.Enabled = false;


        }
        private void DesabilitarControles()
        {
            CodigotextBox1.Enabled = false;
            NombretextBox2.Enabled = false;
            EmailtextBox3.Enabled = false;
            ClavetextBox4.Enabled = false;

            //botones
            Guardarbutton3.Enabled = false;
            Cancelarbutton4.Enabled = false;
            Nuevobutton1.Enabled = true;
            Modificarbutton2.Enabled = true;
            Eliminarbutton5.Enabled = true;


        }

        private void LimpiarControles()
        {
            CodigotextBox1.Clear();
            NombretextBox2.Clear();
            EmailtextBox3.Clear();
            ClavetextBox4.Clear();
        }

        

        private async void LlenarDataGrid()
        {
            UsuariosdataGridView1.DataSource = await DatosUsuario.DevolverUsuariosAsync();
        }


        private void Nuevobutton1_Click(object sender, EventArgs e)
        {
            HabilitarControles();
            Operacion = "nuevo";
        }

        private void Modificarbutton2_Click(object sender, EventArgs e)
        {
            Operacion = "modificar";

            if (UsuariosdataGridView1.SelectedRows.Count > 0)
            {
                CodigotextBox1.Text = UsuariosdataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
                NombretextBox2.Text = UsuariosdataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                EmailtextBox3.Text = UsuariosdataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                ClavetextBox4.Text = UsuariosdataGridView1.CurrentRow.Cells["Clave"].Value.ToString();
                HabilitarControles();
                CodigotextBox1.Enabled = false;
            }
        }

        private void Cancelarbutton4_Click(object sender, EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();
        }


        private void UsuarioForm_Load(object sender, EventArgs e)
        {
            LlenarDataGrid();
        }

        private async void Guardarbutton3_Click(object sender, EventArgs e)
        {
            if (Operacion == "nuevo")
            {
                if (string.IsNullOrEmpty(CodigotextBox1.Text))
                {
                    errorProvider1.SetError(CodigotextBox1, "Ingrese un código");
                    CodigotextBox1.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(NombretextBox2.Text))
                {
                    errorProvider1.SetError(NombretextBox2, "Ingrese un nombre");
                    NombretextBox2.Focus();
                    return;
                }

                user.codigo = CodigotextBox1.Text;
                user.Nombre = NombretextBox2.Text;
                user.Email = EmailtextBox3.Text;
                user.Clave = ClavetextBox4.Text;


                bool inserto = await DatosUsuario.InsertarNuevoUsuarioAsync(user);

                if (inserto)
                {
                    MessageBox.Show("Usuario Guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarDataGrid();
                    LimpiarControles();
                    DesabilitarControles();
                }
                else
                {
                    MessageBox.Show("Usuario No se pudo Guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            else if (Operacion == "modificar")
            {
                if (string.IsNullOrEmpty(CodigotextBox1.Text))
                {
                    errorProvider1.SetError(CodigotextBox1, "Ingrese un código");
                    CodigotextBox1.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(NombretextBox2.Text))
                {
                    errorProvider1.SetError(NombretextBox2, "Ingrese un nombre");
                    NombretextBox2.Focus();
                    return;
                }

                user.codigo = CodigotextBox1.Text;
                user.Nombre = NombretextBox2.Text;
                user.Email = EmailtextBox3.Text;
                user.Clave = ClavetextBox4.Text;

                bool actualizo = await DatosUsuario.ActualizarUsuarioAsync(user);

                if (actualizo)
                {
                    MessageBox.Show("Usuario Actualizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarDataGrid();
                    LimpiarControles();
                    DesabilitarControles();
                }
                else
                {
                    MessageBox.Show("Usuario No se pudo Actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void Eliminarbutton5_Click(object sender, EventArgs e)
        {

            if (UsuariosdataGridView1.SelectedRows.Count > 0)
            {
                bool elimino = await DatosUsuario.EliminarUsuarioAsync(UsuariosdataGridView1.CurrentRow.Cells["Codigo"].Value.ToString());
                if (elimino)
                {
                    MessageBox.Show("Usuario Eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarDataGrid();
                    LimpiarControles();
                    DesabilitarControles();
                }
                else
                {
                    MessageBox.Show("Usuario No se pudo Eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

       
    }
}








