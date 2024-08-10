using capaDeNegocio;
using System.Data;

namespace CapaPresentacion
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedOption = selectUser.SelectedItem.ToString(); // Obtener el valor seleccionado del ComboBox
            string nombre = textBox1.Text; // Asumiendo que tienes un TextBox llamado txtNombre para ingresar el nombre
            string clave = textBox2.Text; // Asumiendo que tienes un TextBox llamado txtClave para ingresar la clave

            OperacionesNegocio operaciones = new OperacionesNegocio(); // Instancia de la clase OperacionesNegocio

            switch (selectedOption)
            {
                case "Usuario comun":
                    // Ejecutar el método para consultar usuario
                    DataTable usuarioResult = operaciones.ConsultarUsuario(nombre, clave);
                    if (usuarioResult.Rows.Count > 0)
                    {
                        // El usuario fue encontrado, manejar el resultado aquí
                        MessageBox.Show("Usuario encontrado: " + usuarioResult.Rows[0]["nombre"].ToString());

                        // Obtener el id del usuario desde el DataTable (ajustar según tu estructura de datos)
                        int idUsuario = Convert.ToInt32(usuarioResult.Rows[0]["id"]);

                        //cambiar al formulario correspondiente 
                        ValidarVisita FormValidarVisita = new ValidarVisita(idUsuario);

                        // Mostrar el nuevo formulario
                        FormValidarVisita.Show();

                        // Ocultar o cerrar el formulario actual
                        this.Hide();
                    }
                    else
                    {
                        // No se encontró el usuario
                        MessageBox.Show("Usuario no encontrado.");
                    }
                    break;

                case "Usuario administrador":
                    // Ejecutar el método para consultar administrador
                    DataTable adminResult = operaciones.ConsultarAdmin(nombre, clave);

                    if (adminResult.Rows.Count > 0)
                    {
                        // El administrador fue encontrado
                        MessageBox.Show("Administrador encontrado: " + adminResult.Rows[0]["nombre"].ToString());

                        // Cambiar al formulario correspondiente
                        panelAdmin FormPanelAdmin = new panelAdmin();

                        // Mostrar el nuevo formulario
                        FormPanelAdmin.Show();

                        // Ocultar o cerrar el formulario actual
                        this.Hide();
                    }
                    else
                    {
                        // No se encontró el administrador
                        MessageBox.Show("Administrador no encontrado.");
                    }

                    break;

                default:
                    MessageBox.Show("Por favor, seleccione una opción válida.");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia del formulario loginRegistro
            loginRegistro nuevoFormulario = new loginRegistro();

            // Mostrar el nuevo formulario
            nuevoFormulario.Show();

            // Ocultar o cerrar el formulario actual
            this.Hide();
            // O si prefieres cerrar el formulario actual completamente
            //this.Close();

        }
    }
}
