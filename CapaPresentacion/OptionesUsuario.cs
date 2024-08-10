using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class OptionesUsuario : Form
    {
        public OptionesUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearUsuario FormCrearUsuario = new CrearUsuario();
            FormCrearUsuario.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EliminarUsuario FormEliminarUsuario = new EliminarUsuario();
            FormEliminarUsuario.Show();

            this.Hide();
        }
    }
}
