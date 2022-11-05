using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;
using System.Data;




namespace Datos
{
    public class TiposDatos
    {

        
        public async Task<DataTable> DevolverTiposAsync()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM tipos;";
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

                throw;
            }
            return dt;
        }


        /*

         */

        public async Task<bool> InsertarNuevoTipoAsync(Tipo tipo)
        {
            bool insert = false;
            try
            {
                string sql = "INSERT INTO tipos VALUES (@Cod, @Nombre);";
                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Cod", MySqlDbType.VarChar, 30).Value = tipo.Cod;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 30).Value = tipo.Nombre;
                        await comando.ExecuteNonQueryAsync();
                        insert = true;
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return insert;
        }



    }
}
