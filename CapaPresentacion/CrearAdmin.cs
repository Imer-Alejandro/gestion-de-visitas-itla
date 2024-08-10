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
    public partial class CrearAdmin : Form
    {
        private OperacionesNegocio operacionesNegocio;
        public CrearAdmin()
        {
            InitializeComponent();
            operacionesNegocio = new OperacionesNegocio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores de los TextBoxes y el DatePicker
                string nombre = Nombre.Text.Trim();
                string apellido = Apellido.Text.Trim();
                string correo = Correo.Text.Trim();
                DateTime fechaNacimiento = FechaNacimiento.Value;
                string departamento = Departamento.Text.Trim(); // Capturando el valor del nuevo campo
                string clave = Clave.Text.Trim();

                // Validar entradas (opcional, pero recomendado)
                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) ||
                    string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(departamento) ||
                    string.IsNullOrEmpty(clave))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Llamar al método para crear un nuevo administrador
                operacionesNegocio.CrearAdmin(nombre, apellido, correo, fechaNacimiento, departamento, clave);

                // Mostrar mensaje de éxito
                MessageBox.Show("Administrador creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos después de la creación
                Nombre.Clear();
                Apellido.Clear();
                Correo.Clear();
                Departamento.Clear(); // Limpiar el nuevo campo
                Clave.Clear();
                FechaNacimiento.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra
                MessageBox.Show($"Error al crear el administrador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
