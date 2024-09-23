using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using datos;
namespace ferreteria_capa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-13BO6VM\\SQLEXPRESS;Initial Catalog=ferreteria;Integrated Security=True;Encrypt=False;");


        private void ingresar_Click(object sender, EventArgs e)
        {
            Form f = new Form2();
            conexion.Open();
            string consulta = "select * from empleados where usuario='"+usuario.Text+"'and contraseña='"+contraseña.Text+"'and tipo='"+tipo.Text+"'";
            SqlCommand cmd = new SqlCommand(consulta,conexion);
            SqlDataReader lector;
            lector = cmd.ExecuteReader();
            if (lector.HasRows == true) 
            {
                MessageBox.Show("bienvenido");
                f.Show();
            }
            else
            {
                MessageBox.Show("no se reconoce el usuario o contraseña");
            }
          
        }
    }
}
