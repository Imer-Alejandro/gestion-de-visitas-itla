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
    public partial class optionesEdificiosAreas : Form
    {
        public optionesEdificiosAreas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearEdificioArea crearEdificioArea = new CrearEdificioArea();
            crearEdificioArea.Show();
            this.Hide();
        }
    }
}
