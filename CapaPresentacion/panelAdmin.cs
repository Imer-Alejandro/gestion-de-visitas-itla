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
    public partial class panelAdmin : Form
    {
        private OperacionesNegocio operacionesNegocio;
        public panelAdmin()
        {
            InitializeComponent();
            operacionesNegocio = new OperacionesNegocio();

            // Cargar las visitas al iniciar el formulario
            CargarVisitas();

            CargarContadores();
        }

        private void CargarContadores()
        {
            try
            {
                // Obtener y mostrar el número total de visitas activas
                int totalVisitas = operacionesNegocio.CountVisitas();
                countVisita.Text = totalVisitas.ToString();

                // Obtener y mostrar el número total de usuarios activos
                int totalUsuarios = operacionesNegocio.CountUsuarios();
                countUsuario.Text = totalUsuarios.ToString();

                // Obtener y mostrar el número total de administradores activos
                int totalAdmins = operacionesNegocio.CountAdmin();
                countAdmin.Text = totalAdmins.ToString();
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si ocurre una excepción
                MessageBox.Show($"Error al cargar los contadores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarVisitas()
        {
            try
            {
                // Obtener el DataTable con las visitas
                DataTable visitas = operacionesNegocio.ConsultarVisitas();

                // Vincular el DataTable al DataGridView
                viewVisitas.DataSource = visitas;
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si ocurre una excepción
                MessageBox.Show($"Error al cargar las visitas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Cambiar al formulario correspondiente
            Login FormLogin = new Login();

            // Mostrar el nuevo formulario
            FormLogin.Show();

            // Ocultar o cerrar el formulario actual
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cambiar al formulario correspondiente
            panelAjustes FormAjustes = new panelAjustes();

            // Mostrar el nuevo formulario
            FormAjustes.Show();

            // Ocultar o cerrar el formulario actual
            this.Hide();
        }

        private void panelAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
