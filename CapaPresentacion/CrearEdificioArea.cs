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
    public partial class CrearEdificioArea : Form
    {
        private OperacionesNegocio operacionesNegocio;
        public CrearEdificioArea()
        {
            InitializeComponent();
            operacionesNegocio = new OperacionesNegocio();

            LoadEdificios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el nombre del edificio desde el TextBox
                string nombreEdificio = NombreEdificio.Text.Trim();

                // Validar la entrada
                if (string.IsNullOrEmpty(nombreEdificio))
                {
                    MessageBox.Show("Por favor, ingrese el nombre del edificio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Llamar al método para crear un nuevo edificio
                operacionesNegocio.CrearEdificio(nombreEdificio);

                // Mostrar mensaje de éxito
                MessageBox.Show("Edificio creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar el campo después de la creación
                NombreEdificio.Clear();
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra
                MessageBox.Show($"Error al crear el edificio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    listEdificios.DisplayMember = "nombre"; // Asumiendo que 'nombre' es el nombre de la columna
                    listEdificios.ValueMember = "id"; // Asumiendo que 'id' es el identificador

                    // Vincular el DataTable al ComboBox
                    listEdificios.DataSource = edificios;
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

        private void CrearEdificioArea_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el ID del edificio seleccionado
                int edificioId = Convert.ToInt32(listEdificios.SelectedValue);

                // Obtener el nombre del área desde el TextBox
                string name = nombreArea.Text;

                // Definir el estado del área como activa (true = 1)
                bool estadoArea = true;

                // Llamar al método de negocio para crear el área
                operacionesNegocio.CrearArea(name, estadoArea, edificioId);

                // Mostrar mensaje de éxito
                MessageBox.Show("Área creada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra
                MessageBox.Show($"Error al crear el área: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
