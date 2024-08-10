using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class OperacionesNegocio
    {
        private Operaciones_db operacionesDb;

        public OperacionesNegocio()
        {
            operacionesDb = new Operaciones_db();
        }

        // Método para registrar un usuario
        public void RegistroUsuario(string nombre, string matricula, string correo, bool estadoUsuario, string clave)
        {
            string procedimiento = "registroUsuario";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@nombre", nombre),
                new SqlParameter("@matricula", matricula),
                new SqlParameter("@correo", correo),
                new SqlParameter("@estado_usuario", estadoUsuario),
                new SqlParameter("@clave", clave)
            };

            operacionesDb.EjecutarProcedimientoSinRetorno(procedimiento, parametros);
        }

        // Método para consultar un usuario
        public DataTable ConsultarUsuario(string matricula, string clave)
        {
            string procedimiento = "consultarUsuario";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@matricula", matricula),
                new SqlParameter("@clave", clave)
            };

            return operacionesDb.EjecutarProcedimientoConRetorno(procedimiento, parametros);
        }

        // Método para registrar visitas
        public void RegistrarVisitas(int usuario, int edificio, int area, string horaSalida, string asuntoVisita, bool estadoVisita, string codigoVisita)
        {
            string procedimiento = "registrarVisitas";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@usuario", usuario),
                new SqlParameter("@edificio", edificio),
                new SqlParameter("@area", area),
                new SqlParameter("@hora_salida", horaSalida),
                new SqlParameter("@asunto_visita", asuntoVisita),
                new SqlParameter("@estado_visita", estadoVisita),
                new SqlParameter("@codigo_visita", codigoVisita)
            };

            operacionesDb.EjecutarProcedimientoSinRetorno(procedimiento, parametros);
        }

        // Método para consultar áreas por edificio
        public DataTable ConsultarAreaEdificio(int edificioId)
        {
            string procedimiento = "consultarAreaEdificio";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@edificio_id", edificioId)
            };

            return operacionesDb.EjecutarProcedimientoConRetorno(procedimiento, parametros);
        }

        // Método para consultar todos los edificios
        public DataTable ConsultaEdificio()
        {
            // Define el nombre del procedimiento almacenado
            string procedimiento = "consultaEdificio";

            // Ejecuta el procedimiento almacenado y retorna el resultado como un DataTable
            return operacionesDb.EjecutarProcedimientoConRetorno(procedimiento, null);
        }

        // Método para consultar todas las áreas
        public DataTable ConsultarArea()
        {
            string procedimiento = "consultarArea";

            return operacionesDb.EjecutarProcedimientoConRetorno(procedimiento, null);
        }

        // Método para confirmar la salida
        public void ConfirmarSalida(string codigoVisita)
        {
            string procedimiento = "confirmarSalida";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@codigo_visita", codigoVisita)
            };

            operacionesDb.EjecutarProcedimientoSinRetorno(procedimiento, parametros);
        }

        // Método para buscar un usuario por nombre
        public DataTable BuscarUsuario(string nombre)
        {
            string procedimiento = "buscarUsuario";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@nombre", nombre)
            };

            return operacionesDb.EjecutarProcedimientoConRetorno(procedimiento, parametros);
        }

        // Método para contar las visitas activas
        public int CountVisitas()
        {
            string procedimiento = "countVisitas";

            DataTable result = operacionesDb.EjecutarProcedimientoConRetorno(procedimiento, null);
            return Convert.ToInt32(result.Rows[0]["TotalVisitasActivas"]);
        }

        // Método para contar los usuarios activos
        public int CountUsuarios()
        {
            string procedimiento = "countUsuarios";

            DataTable result = operacionesDb.EjecutarProcedimientoConRetorno(procedimiento, null);
            return Convert.ToInt32(result.Rows[0]["TotalUsuariosActivos"]);
        }

        // Método para contar los administradores activos
        public int CountAdmin()
        {
            string procedimiento = "countAdmin";

            DataTable result = operacionesDb.EjecutarProcedimientoConRetorno(procedimiento, null);
            return Convert.ToInt32(result.Rows[0]["TotalAdminsActivos"]);
        }

        // Método para consultar un administrador por nombre y clave
        public DataTable ConsultarAdmin(string nombre, string clave)
        {
            string procedimiento = "consultarAdmin";
            SqlParameter[] parametros = new SqlParameter[]
            {
        new SqlParameter("@nombre", nombre),
        new SqlParameter("@clave", clave)
            };

            return operacionesDb.EjecutarProcedimientoConRetorno(procedimiento, parametros);
        }

        public DataTable ConsultarVisitas()
        {
            string procedimiento = "consultarVisitas";
            return operacionesDb.EjecutarProcedimientoConRetorno(procedimiento, null);
        }

        public DataTable ConsultarAdmins()
        {
            string procedimiento = "consultarAdmins";
            return operacionesDb.EjecutarProcedimientoConRetorno(procedimiento, null);
        }

        public void EliminarUsuarioPorMatricula(string matricula)
        {
            string procedimiento = "EliminarUsuarioPorMatricula";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@matricula", matricula)
            };

            operacionesDb.EjecutarProcedimientoSinRetorno(procedimiento, parametros);
        }

        public void CrearAdmin(string nombre, string apellido, string correo, DateTime fechaNacimiento, string departamento, string clave)
        {
            string procedimiento = "CrearAdmin";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@nombre", nombre),
                new SqlParameter("@apellido", apellido),
                new SqlParameter("@correo", correo),
                new SqlParameter("@fechaNacimiento", fechaNacimiento),
                new SqlParameter("@departamento", departamento),
                new SqlParameter("@clave", clave)
            };

            operacionesDb.EjecutarProcedimientoSinRetorno(procedimiento, parametros);
        }

        public void CrearEdificio(string nombre)
        {
            string procedimiento = "CrearEdificio";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@nombre", nombre)
            };

            operacionesDb.EjecutarProcedimientoSinRetorno(procedimiento, parametros);
        }
        public DataTable ConsultarTodosUsuarios()
        {
            // Nombre del procedimiento almacenado
            string procedimiento = "ConsultarTodosUsuarios";

            // Ejecutar el procedimiento almacenado y obtener el DataTable con los resultados
            DataTable resultado = operacionesDb.EjecutarProcedimientoConRetorno(procedimiento, null);

            // Retornar el resultado
            return resultado;
        }

        public void CrearArea(string nombre, bool estado, int edificioId)
        {
            string procedimiento = "crearAreas";
            SqlParameter[] parametros = new SqlParameter[]
            {
            new SqlParameter("@nombre", nombre),
            new SqlParameter("@estado", estado),
            new SqlParameter("@edificio_area", edificioId)
            };

            operacionesDb.EjecutarProcedimientoSinRetorno(procedimiento, parametros);
        }
    }
}