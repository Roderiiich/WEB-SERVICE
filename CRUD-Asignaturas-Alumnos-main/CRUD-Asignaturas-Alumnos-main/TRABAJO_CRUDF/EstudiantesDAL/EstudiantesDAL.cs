using EstudiantesBOL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudiantesDAL
{
    public class EstudiantesDAL
    {

        public string connectionString = "Data Source=L301-17\\SQLEXPRESS;Initial Catalog=Trabajo_Crud;Integrated Security=True;"; // Cadena de conexión a la base de datos

        // Método para insertar un nuevo estudiante en la base de datos
        public void InsertarAlumno(Estu estudiante)
        {
            using (SqlConnection connection = new SqlConnection(connectionString)) // Abre una conexión con la base de datos
            {
                connection.Open(); // Inicia la conexión
                string query = @"INSERT INTO Alumnos (Nombre, ApellidoPAt, ApellidoMat, Email, N_Matricula) 
                         VALUES (@Nombre, @ApellidoPAt, @ApellidoMat, @Email, @N_Matricula);"; // Consulta SQL para insertar un nuevo estudiante

                using (SqlCommand command = new SqlCommand(query, connection)) // Crea un comando SQL
                {
                    // Asigna parámetros al comando SQL, usando valores de los campos del objeto estudiante
                    command.Parameters.AddWithValue("@Nombre", estudiante.Nombre ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@ApellidoPAt", estudiante.ApellidoPAt ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@ApellidoMat", estudiante.ApellidoMat ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Email", estudiante.Email ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@N_Matricula", estudiante.N_Matricula ?? (object)DBNull.Value);

                    command.ExecuteNonQuery(); // Ejecuta el comando en la base de datos
                }
            }
        }

        // Método para actualizar la información de un estudiante existente en la base de datos
        public void ModificarAlumno(Estu estudiante)
        {
            using (SqlConnection connection = new SqlConnection(connectionString)) // Abre una conexión con la base de datos
            {
                connection.Open(); // Inicia la conexión
                string query = "UPDATE Alumnos SET " +
                                "Nombre = @Nombre, " +
                                "ApellidoPAt = @ApellidoPAt, " +
                                "ApellidoMat = @ApellidoMat, " +
                                "Email = @Email, " +
                                "N_Matricula = @N_Matricula " +
                                "WHERE IDAlumnos = @IDAlumnos"; // Consulta SQL para actualizar un estudiante
                using (SqlCommand command = new SqlCommand(query, connection)) // Crea un comando SQL
                {
                    // Asigna parámetros al comando SQL
                    
                    command.Parameters.AddWithValue("@Nombre", estudiante.Nombre ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@ApellidoPAt", estudiante.ApellidoPAt ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@ApellidoMat", estudiante.ApellidoMat);
                    command.Parameters.AddWithValue("@Email", estudiante.Email ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@N_Matricula", estudiante.N_Matricula);
                    command.Parameters.AddWithValue("@IDAlumnos", estudiante.IDAlumnos);
                    command.ExecuteNonQuery();
                    connection.Close(); // Cierra la conexión
                }
            }
        }

        // Método para eliminar un estudiante de la base de datos según su ID
        public int EliminarAlumno(int id)
        {
            int res = 0; // Inicializa una variable para almacenar el resultado de la operación
            using (SqlConnection connection = new SqlConnection(connectionString)) // Abre una conexión con la base de datos
            {
                connection.Open(); // Inicia la conexión
                string query = @"DELETE FROM Alumnos WHERE IDAlumnos = @id"; // Consulta SQL para eliminar un estudiante

                using (SqlCommand command = new SqlCommand(query, connection)) // Crea un comando SQL
                {
                    command.Parameters.AddWithValue("@id", id); // Asigna el parámetro IDAlumno al comando
                    res = command.ExecuteNonQuery(); // Ejecuta el comando y asigna el número de filas afectadas a res
                    connection.Close(); // Cierra la conexión
                }
            }
            return res; // Retorna el resultado de la operación
        }

        // Método para obtener una lista de todos los estudiantes
        public List<Estu> SeleccionarTodos()
        {
            List<Estu> lista = new List<Estu>(); // Inicializa la lista para almacenar estudiantes

            using (SqlConnection connection = new SqlConnection(connectionString)) // Abre una conexión con la base de datos
            {
                connection.Open(); // Inicia la conexión
                string query = "SELECT IDAlumnos, Nombre, ApellidoPAt, ApellidoMat, Email, N_Matricula FROM Alumnos"; // Consulta SQL para obtener todos los estudiantes

                using (SqlCommand command = new SqlCommand(query, connection)) // Crea un comando SQL
                {
                    SqlDataReader dr = command.ExecuteReader(); // Ejecuta el comando y almacena los resultados en un DataReader
                    while (dr.Read()) // Lee cada registro del resultado
                    {
                        // Crea un nuevo objeto estudiante y asigna sus propiedades a partir de los datos leídos
                        Estu estudiante = new Estu();
                        estudiante.IDAlumnos = dr.GetInt32(0);
                        estudiante.Nombre = dr.GetString(1);
                        estudiante.ApellidoPAt = dr.GetString(2);
                        estudiante.ApellidoMat = dr.GetString(3);
                        estudiante.Email = dr.GetString(4);
                        estudiante.N_Matricula = dr.GetString(5);

                        lista.Add(estudiante); // Añade el estudiante a la lista
                    }
                    connection.Close(); // Cierra la conexión
                }
            }
            return lista; // Retorna la lista de estudiantes
        }

        // Método para obtener la información de un estudiante específico según su ID
        public Estu SeleccionarUno(int id)
        {
            Estu obj = new Estu(); // Inicializa un objeto para almacenar el estudiante seleccionado

            using (SqlConnection connection = new SqlConnection(connectionString)) // Abre una conexión con la base de datos
            {
                connection.Open(); // Inicia la conexión
                string query = "SELECT IDAlumnos, Nombre, ApellidoPAt, ApellidoMat, Email, N_Matricula FROM Alumnos WHERE IDAlumno = @id"; // Consulta SQL para obtener un estudiante específico

                using (SqlCommand command = new SqlCommand(query, connection)) // Crea un comando SQL
                {
                    command.Parameters.AddWithValue("@id", id); // Asigna el parámetro IDAlumno al comando
                    SqlDataReader dr = command.ExecuteReader(); // Ejecuta el comando y almacena los resultados en un DataReader
                    while (dr.Read()) // Lee el registro del estudiante seleccionado
                    {
                        // Asigna las propiedades del objeto estudiante a partir de los datos leídos
                        obj.IDAlumnos = dr.GetInt32(0);
                        obj.Nombre = dr.GetString(1);
                        obj.ApellidoPAt = dr.GetString(2);
                        obj.ApellidoMat = dr.GetString(3);
                        obj.Email = dr.GetString(4);
                        obj.N_Matricula = dr.GetString(5);
                    }
                    connection.Close(); // Cierra la conexión
                }
            }
            return obj; // Retorna el objeto con los datos del estudiante
        }


    }
}
