using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccess.Connection;
using Common.Attributes;

namespace DataAccess.Entities
{
    public class Procedimientos
    {
        //Variables
        Connection_Database c = new Connection_Database();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DataTable td = new DataTable();

        public DataTable Mostrar()
        {
            try
            {
                //Muestra los Datos
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_Mostrar";
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();
                td.Load(dr);
            }
            catch(Exception ex)
            {
                string msj = ex.ToString();
            }
            finally
            {
                cmd.Connection = c.CloseConnection();
            }
            return td;
        }

        public DataTable Buscar(string Buscar)
        {
            try
            {
                //Busca Los Datos
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_Buscar";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Buscar", Buscar);
                dr = cmd.ExecuteReader();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                td.Load(dr);
            }
            catch (Exception ex)
            {
                string msj = ex.ToString();
            }
            finally
            {
                cmd.Connection = c.CloseConnection();
            }
            return td;
        }

        public void Insertar(AttributesPeople obj)
        {
            try
            {
                //Inserta Los Datos
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_Insertar";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CODIGO_PAIS", obj.Codigop);
                cmd.Parameters.AddWithValue("@PAIS", obj.Pais);
                cmd.Parameters.AddWithValue("@CODIGO_SALIDA", obj.Codigosalid);
               
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch(Exception ex)
            {
                string msj = ex.ToString();
            }
            finally
            {
                cmd.Connection = c.CloseConnection();
            }
        }

        public void Modificar(AttributesPeople obj)
        {
            try
            {
                //Modiica Los Datos
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_Modificar";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CODIGO_PAIS", obj.Codigop);
                cmd.Parameters.AddWithValue("@PAIS", obj.Pais);
                cmd.Parameters.AddWithValue("@CODIGO_SALIDA", obj.Codigosalid);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                string msj = ex.ToString();
            }
            finally
            {
                cmd.Connection = c.CloseConnection();
            }
        }

        public void Eliminar(AttributesPeople obj)
        {
            try
            {
                //Elimina Los Datos
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_Eliminar";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CODIGO_PAIS", obj.Codigop);
                cmd.ExecuteReader();
                cmd.Parameters.Clear();
            }
            catch(Exception ex)
            {
                string msj = ex.ToString();
            }
            finally
            {
                cmd.Connection = c.CloseConnection();
            }
        }
    }
}
