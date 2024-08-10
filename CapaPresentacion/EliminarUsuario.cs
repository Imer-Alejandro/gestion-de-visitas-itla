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
    public partial class EliminarUsuario : Form
    {
        private OperacionesNegocio operacionesNegocio;
        public EliminarUsuario()
        {
            InitializeComponent();
            operacionesNegocio = new OperacionesNegocio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la matrícula del TextBox
                string MatriculaUsuario = matricula.Text.Trim();

                if (string.IsNullOrEmpty(MatriculaUsuario))
                {
                    MessageBox.Show("Por favor, ingrese una matrícula válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Llamar al método para eliminar el usuario
                operacionesNegocio.EliminarUsuarioPorMatricula(MatriculaUsuario);

                // Mostrar mensaje de éxito
                MessageBox.Show("Usuario eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Opcional: Limpiar el TextBox
                matricula.Clear();

                
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra
                MessageBox.Show($"Error al eliminar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
