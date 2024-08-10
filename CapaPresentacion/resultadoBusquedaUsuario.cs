using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class resultadoBusquedaUsuario : Form
    {
        private String nombreUsuario;
        private OperacionesNegocio operacionesNegocio;
        public resultadoBusquedaUsuario( string nombreUsuario)
        {
            operacionesNegocio = new OperacionesNegocio();
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;

            BuscarUsuario();
        }
        

         private void BuscarUsuario()
        {
            try
            {
                // Obtener el DataTable con las visitas
                DataTable usuario = operacionesNegocio.BuscarUsuario(nombreUsuario);

                // Vincular el DataTable al DataGridView
                viewResult.DataSource = usuario;
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si ocurre una excepción
                MessageBox.Show($"Error al cargar el resultado de busqueda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resultadoBusquedaUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
