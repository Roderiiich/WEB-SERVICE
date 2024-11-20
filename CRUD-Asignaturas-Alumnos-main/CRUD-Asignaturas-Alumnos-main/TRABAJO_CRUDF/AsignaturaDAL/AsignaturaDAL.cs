using AsignaturaBOL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignaturaDAL
{
     public class AsignaturaDAL
    {
        // Cadena de conexión a la base de datos (debe ser ajustada según el entorno)
        public string connectionString = "Data Source=L301-17\\SQLEXPRESS;Initial Catalog=Trabajo_Crud;Integrated Security=True;";

        // Método para insertar una nueva asignatura en la base de datos
        public void InsertarAsignatura(Materia materia)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open(); // Abre la conexión a la base de datos
                string query = @"INSERT INTO Asignaturas (NombreAsignatura, Creditos) 
                                 VALUES (@NombreAsignatura, @Creditos);";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Asigna valores a los parámetros para evitar inyecciones SQL
                    command.Parameters.AddWithValue("@NombreAsignatura", materia.NombreAsignatura ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Creditos", materia.Creditos);

                    command.ExecuteNonQuery(); // Ejecuta la consulta SQL de inserción
                }
            }
        }

        // Método para modificar una asignatura existente en la base de datos
        public void ModificarAsignatura(Materia materia)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open(); // Abre la conexión a la base de datos
                string query = "UPDATE Asignaturas SET " +
                               "NombreAsignatura = @NombreAsignatura, " +
                               "Creditos = @Creditos " +
                               "WHERE CodigoAsignatura = @CodigoAsignatura"; // Actualiza solo donde coincida el CódigoAsignatura

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Asigna valores a los parámetros para evitar inyecciones SQL
                    command.Parameters.AddWithValue("@NombreAsignatura", materia.NombreAsignatura);
                    command.Parameters.AddWithValue("@Creditos", materia.Creditos);
                    command.Parameters.AddWithValue("@CodigoAsignatura", materia.CodigoAsignatura);

                    command.ExecuteNonQuery(); // Ejecuta la consulta SQL de actualización
                    connection.Close(); // Cierra la conexión a la base de datos
                }
            }
        }

        // Método para eliminar una asignatura de la base de datos según su ID
        public int EliminarAsignatura(int id)
        {
            int res = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open(); // Abre la conexión a la base de datos
                string query = @"DELETE FROM Asignaturas WHERE CodigoAsignatura = @id"; // Consulta para eliminar

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Asigna el valor del parámetro ID
                    command.Parameters.AddWithValue("@id", id);
                    res = command.ExecuteNonQuery(); // Ejecuta la consulta SQL de eliminación y almacena el resultado
                    connection.Close(); // Cierra la conexión a la base de datos
                }
            }
            return res; // Retorna el resultado de la operación
        }

        // Método para seleccionar todas las asignaturas de la base de datos y devolverlas en una lista
        public List<Materia> SeleccionarTodosAsignatura()
        {
            List<Materia> lista = new List<Materia>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open(); // Abre la conexión a la base de datos
                string query = "SELECT CodigoAsignatura, NombreAsignatura, Creditos FROM Asignaturas"; // Consulta para seleccionar todas las asignaturas

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader dr = command.ExecuteReader(); // Ejecuta la consulta y obtiene los datos

                    while (dr.Read()) // Lee cada registro de la consulta
                    {
                        Materia materia = new Materia(); // Crea un nuevo objeto Materia y asigna sus propiedades
                        materia.CodigoAsignatura = dr.GetInt32(0);
                        materia.NombreAsignatura = dr.GetString(1);
                        materia.Creditos = dr.GetInt32(2);

                        lista.Add(materia); // Añade el objeto a la lista de resultados
                    }
                    connection.Close(); // Cierra la conexión a la base de datos
                }
            }
            return lista; // Retorna la lista de materias obtenidas
        }

        // Método para seleccionar una única asignatura de la base de datos según su ID
        public Materia SeleccionarUnoAsignatura(int id)
        {
            Materia obj = new Materia();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open(); // Abre la conexión a la base de datos
                string query = "SELECT CodigoAsignatura, NombreAsignatura, Creditos FROM Asignaturas WHERE id = @id"; // Consulta para seleccionar una asignatura específica

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Asigna el valor del parámetro ID
                    command.Parameters.AddWithValue("@id", id);
                    SqlDataReader dr = command.ExecuteReader(); // Ejecuta la consulta y obtiene el registro

                    while (dr.Read()) // Lee el registro encontrado
                    {
                        obj.CodigoAsignatura = dr.GetInt32(0);
                        obj.NombreAsignatura = dr.GetString(1);
                        obj.Creditos = dr.GetInt32(2);
                    }
                    connection.Close(); // Cierra la conexión a la base de datos
                }
            }
            return obj; // Retorna el objeto Materia con los datos obtenidos
        }
    }
}

    

