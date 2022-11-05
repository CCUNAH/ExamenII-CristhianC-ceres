using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Ticketdatos
    {
        public async Task<DataTable> DevolverTicketsAsync()
        {
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM ticket;";

                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;

                        MySqlDataReader dr = (MySqlDataReader)await comando.ExecuteReaderAsync();
                        dt.Load(dr);
                    }
                }
            }
            catch (Exception)
            {
            }
            return dt;
        }

        public async Task<bool> InsertarNuevoTicketAsync(Ticket tickets)
        {
            bool insert = false;
            try
            {
                string sql = "INSERT INTO ticket VALUES (@Id, @Fecha, @IdentidadCliente, @NombreCliente, @TipoSoporte, @TipoEquipo, @DescripcionProblema,@DescripcionSolucion,@Costo);";

                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Id", MySqlDbType.VarChar, 30).Value = tickets.Id;
                        comando.Parameters.Add("@Fecha", MySqlDbType.DateTime).Value = tickets.fecha;
                        comando.Parameters.Add("@IdentidadCliente", MySqlDbType.VarChar, 40).Value = tickets.Identidad;
                        comando.Parameters.Add("@NombreCliente", MySqlDbType.VarChar, 45).Value = tickets.NombreCliente;
                        comando.Parameters.Add("@TipoSoporte", MySqlDbType.VarChar, 75).Value = tickets.TipoSoporte;
                        comando.Parameters.Add("@TipoEquipo", MySqlDbType.VarChar, 75).Value = tickets.Tipoequipo;
                        comando.Parameters.Add("@DescripcionProblema", MySqlDbType.VarChar, 120).Value = tickets.DescripcionProblema;
                        comando.Parameters.Add("@DescripcionSolucion", MySqlDbType.VarChar, 120).Value = tickets.DescripcionSolucion;
                        comando.Parameters.Add("@Costo", MySqlDbType.Decimal).Value = tickets.Costo;
                        await comando.ExecuteNonQueryAsync();
                        insert = true;
                    }
                }
            }
            catch (Exception)
            {
            }
            return insert;
        }


        public async Task<bool> ActualizarTicketAsync(Ticket tickets)
        {
            bool actualizo = false;
            try
            {
                string sql = "UPDATE ticket SET  NombreCliente = @NombreCliente, TipoSoporte = @TipoSoporte, TipoEquipo = @TipoEquipo, DescripcionProblema=@DescripcionProblema, DescripcionSolucion=@DescripcionSolucion, Costo=@Costo  WHERE Id = @Id;";

                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Id", MySqlDbType.VarChar, 20).Value = tickets.Id;
                        comando.Parameters.Add("@Fecha", MySqlDbType.DateTime).Value = tickets.fecha;
                        comando.Parameters.Add("@IdentidadCliente", MySqlDbType.VarChar, 40).Value = tickets.Identidad;
                        comando.Parameters.Add("@NombreCliente", MySqlDbType.VarChar, 45).Value = tickets.NombreCliente;
                        comando.Parameters.Add("@TipoSoporte", MySqlDbType.VarChar, 50).Value = tickets.TipoSoporte;
                        comando.Parameters.Add("@TipoEquipo", MySqlDbType.VarChar, 50).Value = tickets.Tipoequipo;
                        comando.Parameters.Add("@DescripcionProblema", MySqlDbType.VarChar, 150).Value = tickets.DescripcionProblema;
                        comando.Parameters.Add("@DescripcionSolucion", MySqlDbType.VarChar, 150).Value = tickets.DescripcionSolucion;
                        comando.Parameters.Add("@Costo", MySqlDbType.Decimal).Value = tickets.Costo;
                       
                        await comando.ExecuteNonQueryAsync();
                        actualizo = true;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return actualizo;
        }

        public async Task<bool> EliminarTicketAsync(string id)
        {
            bool elimino = false;
            try
            {
                string sql = "DELETE FROM ticket WHERE Id = @Id;";

                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Id", MySqlDbType.VarChar, 30).Value = id;
                        await comando.ExecuteNonQueryAsync();
                        elimino = true;
                    }
                }
            }
            catch (Exception)
            {
            }
            return elimino;
        }
    }
}
