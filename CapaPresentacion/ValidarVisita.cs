using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaDeNegocio;
namespace CapaPresentacion
{
    public partial class ValidarVisita : Form
    {
        private OperacionesNegocio operacionesNegocio;
        private int idUsuario;
        private int idEdificio;
        public ValidarVisita(int id_user)
        {
            InitializeComponent();
            operacionesNegocio = new OperacionesNegocio();
            idUsuario = id_user; // Asignar el ID del usuario que realizará el registro de visita
            LoadEdificios();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int edificioId = Convert.ToInt32(listadoEdificios.SelectedValue);
                int areaId = Convert.ToInt32(listAreaEdificios.SelectedValue);
                string AsuntoVisita = asuntoVisita.Text;
                string horaSalida = fechaSalida.Value.ToString("HH:mm:ss"); // Formato de hora en 24 horas

                // Generar un código de visita aleatorio de 5 dígitos
                Random random = new Random();
                string codigoVisita = random.Next(10000, 100000).ToString();

                bool estadoVisita = true; // Establecer el estado de la visita

                // Llamar al método para registrar la visita
                operacionesNegocio.RegistrarVisitas(idUsuario, edificioId, areaId, horaSalida, AsuntoVisita, estadoVisita, codigoVisita);

                MessageBox.Show("Visita registrada exitosamente.", "Éxito", MessageBoxButtons.OK);
                MessageBox.Show("Código de visita: " + codigoVisita);

                // Regresar al login luego del registro de visita
                Login FormLogin = new Login();
                FormLogin.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la visita: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadEdificios()
        {
            try
            {
                // Recuperar el DataTable con los edificios
                DataTable edificios = operacionesNegocio.ConsultaEdificio();


                // Verificar si se recuperaron datos
                if (edificios.Rows.Count > 0)
                {


                    // Configurar el ComboBox para mostrar un nombre y usar un ID como valor
                    listadoEdificios.DisplayMember = "nombre"; // Asumiendo que 'nombre' es el nombre de la columna
                    listadoEdificios.ValueMember = "id"; // Asumiendo que 'id' es el identificador

                    // Vincular el DataTable al ComboBox
                    listadoEdificios.DataSource = edificios;

                }
                else
                {
                    // Manejar el caso donde no se recuperaron datos
                    MessageBox.Show("No se encontraron edificios.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error si ocurre un problema al recuperar los datos
                MessageBox.Show($"Error al cargar los edificios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para cargar las áreas del edificio seleccionado en el ComboBox
        private void CargarAreas(int edificioId)
        {
            try
            {
                DataTable areas = operacionesNegocio.ConsultarAreaEdificio(edificioId);

                if (areas.Rows.Count > 0)
                {

                    listAreaEdificios.DisplayMember = "nombre"; // Nombre de la columna para mostrar
                    listAreaEdificios.ValueMember = "id"; // ID de la columna para usar como valor
                    listAreaEdificios.DataSource = areas;
                }
                else
                {
                    listAreaEdificios.DataSource = null; // Limpiar el DataSource
                    MessageBox.Show("No se encontraron áreas para el edificio seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las áreas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarAreas(idEdificio);

            MessageBox.Show(" Areas optenidas");
        }

        private void listEdificios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listadoEdificios.SelectedValue != null)
            {
                idEdificio = Convert.ToInt32(listadoEdificios.SelectedValue);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConfirmarSalida FormConfirmarSalida = new ConfirmarSalida();
            FormConfirmarSalida.Show();
            this.Hide();

        }

        private void ValidarVisita_Load(object sender, EventArgs e)
        {

        }
    }
}
