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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("Data Source = DESKTOP - 13BO6VM\\SQLEXPRESS; Initial Catalog = ferreteria; Integrated Security = True; Encrypt=False;Trust Server Certificate=True");

        private void Form6_Load(object sender, EventArgs e)
        {
            string consulta = "select * from empleados";
            SqlDataAdapter adap = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void volver_Click(object sender, EventArgs e)
        {
            Form f = new Form2();
            f.Show();
        }
    }
}
