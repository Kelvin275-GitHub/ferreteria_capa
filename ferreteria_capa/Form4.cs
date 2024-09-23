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

namespace ferreteria_capa
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("Data Source = DESKTOP - 13BO6VM\\SQLEXPRESS; Initial Catalog = ferreteria; Integrated Security = True; Encrypt=False;Trust Server Certificate=True");
        private void salir_Click(object sender, EventArgs e)
        {
            Form f = new Form2();
            f.Show();
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "update empleados set id=" + id.Text + ", tipo='" + tipo.Text + "', nombre='" + nombre.Text + "', usuario='" + usuario.Text + "', contraseña='" + contraseña.Text + "'";
            SqlCommand cmd = new SqlCommand(consulta,conexion);
            int cant;
            cant = cmd.ExecuteNonQuery();
            if(cant>0)
            {
                MessageBox.Show("registro modificados");
            }
        }
    }
}
