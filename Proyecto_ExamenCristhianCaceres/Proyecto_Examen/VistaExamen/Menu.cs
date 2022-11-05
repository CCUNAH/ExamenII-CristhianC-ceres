using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VistaExamen
{
    public partial class Menu : Syncfusion.Windows.Forms.Office2010Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        Usuario formularioUser = null;
        Ticket formularioTicket = null;
        Tipos formularioTipo = null;


        public FormClosedEventHandler UsuarioForm_FormClosed { get; private set; }
        public FormClosedEventHandler Ticket_FormClosed { get; private set; }
        public FormClosedEventHandler Tipo_FrmClosed { get; private set; }

        private void ListaUsuariotoolStripButton1_Click(object sender, EventArgs e)
        {
            if (formularioUser == null)
            {
                formularioUser = new Usuario();
                formularioUser.MdiParent = this;
                formularioUser.FormClosed += UsuarioForm_FormClosed;
                formularioUser.Show();
            }
            else
            {
                formularioUser.Activate();
            }
        }

        private void TickettoolStripButton1_Click(object sender, EventArgs e)
        {
            if (formularioTicket == null)
            {
                formularioTicket = new Ticket();
                formularioTicket.MdiParent = this;
                formularioTicket.FormClosed += Ticket_FormClosed;
                formularioTicket.Show();
            }
            else
            {
                formularioTicket.Activate();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (formularioTipo==null)
            {
                formularioTipo = new Tipos();
                formularioTipo.MdiParent = this;
                formularioTipo.FormClosed += Tipo_FrmClosed;
                formularioTipo.Show();

            }
            else
            {
                formularioTipo.Activate();
            }
        }
    }
    }

