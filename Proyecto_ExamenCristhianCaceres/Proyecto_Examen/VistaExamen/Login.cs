using Datos;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void Aceptarbutton_Click(object sender, EventArgs e)
        {
            if(UsuariotextBox.Text==string.Empty)
            {
                errorProvider1.SetError(UsuariotextBox, "Ingrese un Usuario");
                UsuariotextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if(string.IsNullOrEmpty(ClavetextBox.Text))
            {
                errorProvider1.SetError(ClavetextBox, "Ingrese una Calve");
                ClavetextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            UsuarioDatos usuarioDatos=new UsuarioDatos();
            bool usuariovalido= await usuarioDatos.ValidarUsuarioAsync(UsuariotextBox.Text, ClavetextBox.Text);

            if(usuariovalido)
            {
                Menu principalform = new Menu();
                this.Hide();
                principalform.Show();
            }
            else
            {
                MessageBox.Show("Datos incorrectos", "Error", MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }

        }
        

        private void UsuariotextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(UsuariotextBox.Text))
            {
                errorProvider1.Clear();
            }
        }

        private void ClavetextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(UsuariotextBox.Text))
            {
                errorProvider1.Clear();
            }
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
