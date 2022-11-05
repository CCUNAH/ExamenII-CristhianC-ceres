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
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }


        Ticketdatos ticketdatos = new Datos.Ticketdatos();
        string Operacion = string.Empty;//INCIALIZACION DE VARIABLE
        Entidades.Ticket ticket = new Entidades.Ticket();


        private void HabilitarControles()
        {
            FechadateTimePicker1.Enabled = true;
            IdTickettextBox1.Enabled = true;
            NcientetextBox2.Enabled = true;
            SoportecomboBox1.Enabled = true;
            EquipocomboBox2.Enabled = true;
            ProblematextBox5.Enabled = true;
            SoluciontextBox3.Enabled = true;
            CostotextBox4.Enabled = true;
            IdentidadMaskedTextBox.Enabled = true;

            //botones
            Guardarbutton5.Enabled = true;
            Cancelarbutton4.Enabled = true;
            Nuevobutton1.Enabled = false;
            Modificarbutton2.Enabled = false;
            Eliminarbutton3.Enabled = false;


        }
        private void DesabilitarControles()
        {
            FechadateTimePicker1.Enabled = false;
            IdTickettextBox1.Enabled = false;
            NcientetextBox2.Enabled = false;
            SoportecomboBox1.Enabled = false;
            EquipocomboBox2.Enabled = false;
            ProblematextBox5.Enabled = false;
            SoluciontextBox3.Enabled = false;
            CostotextBox4.Enabled = false;
            IdentidadMaskedTextBox.Enabled = false;

            //botones
            Guardarbutton5.Enabled = false;
            Cancelarbutton4.Enabled = false;
            Nuevobutton1.Enabled = true;
            Modificarbutton2.Enabled = true;
            Eliminarbutton3.Enabled = true;


        }

        private void LimpiarControles()
        {
            IdTickettextBox1.Clear();
            NcientetextBox2.Clear();
            SoportecomboBox1.Text = string.Empty;
            EquipocomboBox2.Text = string.Empty;
            ProblematextBox5.Clear();
            SoluciontextBox3.Clear();
            CostotextBox4.Clear();



        }

  

        private async void LLenarDataGrid()
        {
            TicketdataGridView1.DataSource= await ticketdatos.DevolverTicketsAsync();
        }

        private void Nuevobutton1_Click(object sender, EventArgs e)
        {
            HabilitarControles();
            Operacion = "nuevo";
        }

        private async void Guardarbutton5_Click(object sender, EventArgs e)
        {
          

            if (Operacion == "nuevo")
            {
                if (string.IsNullOrEmpty(IdTickettextBox1.Text))
                {
                    errorProvider1.SetError(IdTickettextBox1, "Ingrese el Id del ticket");
                    IdTickettextBox1.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(IdentidadMaskedTextBox.Text))
                {
                    errorProvider1.SetError(IdentidadMaskedTextBox, "Ingrese la Id del cliente");
                    IdentidadMaskedTextBox.Focus();
                    return;
                }

                ticket.Id = Convert.ToInt32(IdTickettextBox1.Text);
                ticket.fecha = FechadateTimePicker1.Value;
                ticket.NombreCliente = NcientetextBox2.Text;
                ticket.Identidad = IdentidadMaskedTextBox.Text;
                ticket.TipoSoporte = SoportecomboBox1.Text;
                ticket.Tipoequipo =EquipocomboBox2.Text;
                ticket.DescripcionProblema= ProblematextBox5.Text;
                ticket.DescripcionSolucion= SoluciontextBox3.Text;
                ticket.Costo = Convert.ToDecimal(CostotextBox4.Text);


                bool inserto = await ticketdatos.InsertarNuevoTicketAsync(ticket);
                if (inserto)
                {
                    MessageBox.Show("Ticket Guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LLenarDataGrid();
                    LimpiarControles();
                    DesabilitarControles();
                }
                else
                {
                    MessageBox.Show("Ticket No se pudo Guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (Operacion == "modificar")
            {
                if (string.IsNullOrEmpty(IdTickettextBox1.Text))
                {
                    errorProvider1.SetError(IdTickettextBox1, "Ingrese el Id del ticket");
                    IdTickettextBox1.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(IdentidadMaskedTextBox.Text))
                {
                    errorProvider1.SetError(IdentidadMaskedTextBox, "Ingrese la Id del cliente");
                    IdentidadMaskedTextBox.Focus();
                    return;
                }

                ticket.Id = Convert.ToInt32(IdTickettextBox1.Text);
                ticket.fecha = FechadateTimePicker1.Value;
                ticket.NombreCliente = NcientetextBox2.Text;
                ticket.Identidad = IdentidadMaskedTextBox.Text;
                ticket.TipoSoporte = SoportecomboBox1.Text;
                ticket.Tipoequipo = EquipocomboBox2.Text;
                ticket.DescripcionProblema = ProblematextBox5.Text;
                ticket.DescripcionSolucion = SoluciontextBox3.Text;
                ticket.Costo = Convert.ToDecimal(CostotextBox4.Text);

                bool actualizo = await ticketdatos.ActualizarTicketAsync(ticket);
                if (actualizo)
                {
                    MessageBox.Show("Ticket Actualizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LLenarDataGrid();
                    LimpiarControles();
                    DesabilitarControles();
                }
                else
                {
                    MessageBox.Show("Ticket No se pudo actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }

        private void Cancelarbutton4_Click(object sender, EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();
        }

        private void Modificarbutton2_Click(object sender, EventArgs e)
        {
            IdentidadMaskedTextBox.Enabled=false;
            FechadateTimePicker1.Enabled = false;
            IdTickettextBox1.Enabled = false;



            Operacion = "modificar";
            if (TicketdataGridView1.SelectedRows.Count>0)
            {
                IdTickettextBox1.Text = TicketdataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                FechadateTimePicker1.Value = (DateTime)TicketdataGridView1.CurrentRow.Cells["Fecha"].Value;
                NcientetextBox2.Text = TicketdataGridView1.CurrentRow.Cells["NombreCliente"].Value.ToString();
                IdentidadMaskedTextBox.Text = TicketdataGridView1.CurrentRow.Cells["IdentidadCliente"].Value.ToString();
                SoportecomboBox1.Text = TicketdataGridView1.CurrentRow.Cells["TipoSoporte"].Value.ToString();
                EquipocomboBox2.Text = TicketdataGridView1.CurrentRow.Cells["TipoEquipo"].Value.ToString();
                ProblematextBox5.Text = TicketdataGridView1.CurrentRow.Cells["DescripcionProblema"].Value.ToString();
                SoluciontextBox3.Text = TicketdataGridView1.CurrentRow.Cells["DescripcionSolucion"].Value.ToString();
                CostotextBox4.Text = TicketdataGridView1.CurrentRow.Cells["Costo"].Value.ToString();
                HabilitarControles();
                FechadateTimePicker1.Enabled = false;
                IdTickettextBox1.Enabled = false;
                IdentidadMaskedTextBox.Enabled=false;
            }
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            LLenarDataGrid();
        }

        private async void Eliminarbutton3_Click(object sender, EventArgs e)
        {
           

            if (TicketdataGridView1.SelectedRows.Count > 0)
            {
                bool elimino = await ticketdatos.EliminarTicketAsync(TicketdataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                if (elimino)
                {
                    MessageBox.Show("Ticket Eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LLenarDataGrid();
                    LimpiarControles();
                    DesabilitarControles();
                }
            }


        }
    }
}
