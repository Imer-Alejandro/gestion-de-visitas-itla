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
    public partial class ConfirmarSalida : Form
    {
        private OperacionesNegocio operacionesNegocio;

        public ConfirmarSalida()
        {
            InitializeComponent();
            operacionesNegocio = new OperacionesNegocio();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el código de visita desde el TextBox
                string code = codigoVisita.Text;

                // Validar que el código de visita no esté vacío
                if (string.IsNullOrWhiteSpace(code))
                {
                    MessageBox.Show("Por favor, ingrese un código de visita.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Llamar al método para confirmar la salida
                operacionesNegocio.ConfirmarSalida(code);

                // Mostrar mensaje de éxito
                MessageBox.Show("Salida confirmada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Opcional: Limpiar el TextBox después de confirmar la salida
                codigoVisita.Text = string.Empty;

                //cambiar al formulario correspondiente 
                Login FormLogin = new Login();

                // Mostrar el nuevo formulario
                FormLogin.Show();

                // Ocultar o cerrar el formulario actual
                this.Hide();
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra
                MessageBox.Show($"Error al confirmar la salida: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
