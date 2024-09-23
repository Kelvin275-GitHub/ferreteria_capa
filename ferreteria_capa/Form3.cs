using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using datos;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ferreteria_capa
{
    public partial class tabla3 : Form
    {

        
        private void Actualizar()
        {
            conexionbd conexion = new conexionbd();
            DataTable dt = new DataTable();
            SqlCommand query = new SqlCommand("select + from empleados", conexion.ruta);
            conexion.abrirconexion();
            SqlDataAdapter da = new SqlDataAdapter();
            da.Fill(dt);
            
            conexion.CerrarConexion();

        }

        private void salir_Click(object sender, EventArgs e)
        {
            Form f = new Form2();
            f.Show();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                   
                    registrar.FuncionRegitro ( tipo.Text, nombre.Text , usuario.Text,contraseña.Text);
                    
                    MessageBox.Show("Datos Registardos");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.ToString());
                }
            }
        }
    }
}
