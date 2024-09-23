using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using datos;

namespace ferreteria_capa
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
       

        public void eliminar_Click(object sender, EventArgs e)
        {
            
            try
            {
                registrar Res = new registrar();
                Res.FuncionEliminar id= id.text;
                MessageBox.Show("datos borrados");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
        }

        private void volver_Click(object sender, EventArgs e)
        {
            Form f=new Form2();
            f.Show();
        }
    }
}
