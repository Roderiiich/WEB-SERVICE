using EstudiantesBOL;
using EstudiantesDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudiantesBL
{
    public class EstudiantesBL
    {
        // Método para insertar un nuevo estudiante en la base de datos
        public static bool Insertar(Estu alumno)
        {
            try
            {
                EstudiantesDAL.EstudiantesDAL obj = new EstudiantesDAL.EstudiantesDAL(); // Instancia la clase DAL
                obj.InsertarAlumno(alumno); // Llama al método de inserción en la capa DAL
                return true; // Retorna true si se completa sin excepciones
            }
            catch (Exception)
            {
                return false; // Retorna false si ocurre alguna excepción
            }
        }

        // Método para modificar los datos de un estudiante existente
        public static bool Modificar(Estu alumno)
        {
            try
            {
                EstudiantesDAL.EstudiantesDAL obj = new EstudiantesDAL.EstudiantesDAL(); // Instancia la clase DAL
                obj.ModificarAlumno(alumno); // Llama al método de modificación en la capa DAL
                return true; // Retorna true si se completa sin excepciones
            }
            catch (Exception)
            {
                return false; // Retorna false si ocurre alguna excepción
            }
        }


      

        // Método para eliminar un estudiante de la base de datos según su ID
        public static bool Eliminar(int id)
        {
            try
            {
                EstudiantesDAL.EstudiantesDAL obj = new EstudiantesDAL.EstudiantesDAL(); // Instancia la clase DAL
                obj.EliminarAlumno(id); // Llama al método de eliminación en la capa DAL
                return true; // Retorna true si se completa sin excepciones
            }
            catch (Exception)
            {
                return false; // Retorna false si ocurre alguna excepción
            }
        }

        // Método para obtener la lista de todos los estudiantes de la base de datos
        public static List<Estu> SeleccionarTodos()
        {
            List<Estu> lista = new List<Estu>(); // Inicializa la lista que contendrá los estudiantes
            try
            {
                EstudiantesDAL.EstudiantesDAL obj = new EstudiantesDAL.EstudiantesDAL(); // Instancia la clase DAL
                lista = obj.SeleccionarTodos(); // Llama al método de selección en la capa DAL
                return lista; // Retorna la lista de estudiantes obtenidos
            }
            catch (Exception)
            {
                return null; // Retorna null si ocurre alguna excepción
            }
        }

        // Método para obtener los datos de un solo estudiante según su ID
        public static Estu SeleccionarUno(int id)
        {
            Estu estudiante = new Estu(); // Inicializa el objeto que contendrá los datos del estudiante
            try
            {
                EstudiantesDAL.EstudiantesDAL obj = new EstudiantesDAL.EstudiantesDAL(); // Instancia la clase DAL
                estudiante = obj.SeleccionarUno(id); // Llama al método de selección individual en la capa DAL
                return estudiante; // Retorna el objeto con los datos del estudiante obtenido
            }
            catch (Exception)
            {
                return null; // Retorna null si ocurre alguna excepción
            }
        }

    }
}

