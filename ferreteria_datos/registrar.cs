using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ferreteria_datos
{
    public class registrar
    {
        //--->Referenciar la Clase
        conexionbd conexion = new conexionbd();
        //--->Comando SQLServer
        SqlCommand cmd = new SqlCommand();

        public void FuncionRegitro(int id, string tipo, string nombre, string usuario, string contraseña)
        {

            cmd.Connection = conexion.abrirconexion();

            cmd.CommandText = "regristro";

            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@contraseña", contraseña);
            cmd.ExecuteNonQuery();
            conexion.CerrarConexion();


        }
        public void FuncionModificar(int id, string tipo, string nombre, string usuario, string contraseña)
        {

            cmd.Connection = conexion.abrirconexion();

            cmd.CommandText = "modificacion_empleados";

            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@contraseña", contraseña);
            cmd.ExecuteNonQuery();
            conexion.CerrarConexion();


        }
        public void FuncionEliminar(int id, string tipo, string nombre, string usuario, string contraseña)
        {

            cmd.Connection = conexion.abrirconexion();

            cmd.CommandText = "baja";

            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@contraseña", contraseña);
            cmd.ExecuteNonQuery();
            conexion.CerrarConexion();

        }
    }
}
