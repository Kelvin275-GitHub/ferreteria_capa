using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ferreteria_capa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ver_Click(object sender, EventArgs e)
        {
            Form f = new Form6();
            f.Show();
        }

        private void editar_Click(object sender, EventArgs e)
        {
            Form f = new Form4();
            f.Show();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            Form f = new Form5();
            f.Show();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            Form f = new tabla3();
            f.Show();
        }
    }
}
