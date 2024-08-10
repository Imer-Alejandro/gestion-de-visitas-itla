using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace CapaPresentacion
{
    public partial class loginRegistro : Form
    {
        public loginRegistro()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores de los TextBox
                string matricula = Matricula.Text.Trim();
                string nombre = Nombre.Text.Trim();
                string correo = Correo.Text.Trim();
                string carrera = Carrera.Text.Trim(); // Este valor no se usa actualmente en el procedimiento almacenado
                string clave = Clave.Text.Trim();

                // Verificar que todos los campos requeridos no estén vacíos
                if (string.IsNullOrEmpty(matricula) || string.IsNullOrEmpty(nombre) ||
                    string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(clave))
                {
                    MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Determinar el estado del usuario
                // Aquí puedes establecer el valor deseado, en este ejemplo, lo establecemos como verdadero.
                bool estadoUsuario = true; // Establecer el estado del usuario como activo (1)

                // Llamar al método de registro de usuario en la capa de negocio
                OperacionesNegocio operacionesNegocio = new OperacionesNegocio();
                operacionesNegocio.RegistroUsuario(nombre, matricula, correo, estadoUsuario, clave);

                // Mostrar un mensaje de éxito
                MessageBox.Show("Usuario registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos de texto después del registro
                Matricula.Clear();
                Nombre.Clear();
                Correo.Clear();
                Carrera.Clear();
                Clave.Clear();


                //cambiar al formulario correspondiente 
                Login FormLogin = new Login();

                // Mostrar el nuevo formulario
                FormLogin.Show();

                // Ocultar o cerrar el formulario actual
                this.Hide();
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante el registro
                MessageBox.Show("Ocurrió un error al registrar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
