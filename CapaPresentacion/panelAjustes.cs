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
    public partial class panelAjustes : Form
    {
        private OperacionesNegocio operacionesNegocio;

        public panelAjustes()
        {
            InitializeComponent();
            operacionesNegocio = new OperacionesNegocio();

            CargarContadores();

            CargarVisitas();
            CargarAdmins();
            CargarUsuarios();
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

        private void CargarUsuarios()
        {
            try
            {
                // Obtener el DataTable con las visitas
                DataTable usuarios = operacionesNegocio.ConsultarTodosUsuarios();

                // Vincular el DataTable al DataGridView
                viewUsuarios.DataSource = usuarios;
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si ocurre una excepción
                MessageBox.Show($"Error al cargar las usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CargarAdmins()
        {
            try
            {
                // Obtener el DataTable con las visitas
                DataTable admins = operacionesNegocio.ConsultarAdmins();

                // Vincular el DataTable al DataGridView
                viewAdmins.DataSource = admins;
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si ocurre una excepción
                MessageBox.Show($"Error al cargar los admins: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelAdmin FormAdmin = new panelAdmin();

            FormAdmin.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login FormLogin = new Login();
            FormLogin.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (NombreUsuario.Text != "")
            {
                resultadoBusquedaUsuario FormResult = new resultadoBusquedaUsuario(NombreUsuario.Text);

                FormResult.Show();

                NombreUsuario.Text = "";
            }
            else
            {
                MessageBox.Show("Ingrese un nombre primero");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OptionesUsuario FormOptionesUsuario = new OptionesUsuario();
            FormOptionesUsuario.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OptionesAdmin FormOptionesAdmin = new OptionesAdmin();
            FormOptionesAdmin.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            optionesEdificiosAreas optionesEdificiosAreas = new optionesEdificiosAreas();
            optionesEdificiosAreas.Show();
        }

        private void panelAjustes_Load(object sender, EventArgs e)
        {

        }
    }
}
