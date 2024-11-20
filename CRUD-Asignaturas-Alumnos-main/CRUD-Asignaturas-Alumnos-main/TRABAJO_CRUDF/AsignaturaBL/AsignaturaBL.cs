using AsignaturaBOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignaturaBL
{
    public class AsignaturaBL
    {

        // Método para insertar una nueva materia en la base de datos.
        public static bool Insertar(Materia materia)
        {
            try
            {
                // Crea una instancia de la capa de datos (DAL) y llama al método para insertar.
                AsignaturaDAL.AsignaturaDAL obj = new AsignaturaDAL.AsignaturaDAL();
                obj.InsertarAsignatura(materia);
                return true; // Retorna true si la inserción fue exitosa.
            }
            catch (Exception)
            {
                return false; // Retorna false si ocurre alguna excepción.
            }
        }

        // Método para modificar una materia existente en la base de datos.
        public static bool Modificar(Materia materia)
        {
            try
            {
                // Crea una instancia de la capa de datos (DAL) y llama al método para modificar.
                AsignaturaDAL.AsignaturaDAL obj = new AsignaturaDAL.AsignaturaDAL();
                obj.ModificarAsignatura(materia);
                return true; // Retorna true si la modificación fue exitosa.
            }
            catch (Exception)
            {
                return false; // Retorna false si ocurre alguna excepción.
            }
        }


        // Método para eliminar una materia de la base de datos por su ID.
        public static bool Eliminar(int id)
        {
            try
            {
                // Crea una instancia de la capa de datos (DAL) y llama al método para eliminar.
                AsignaturaDAL.AsignaturaDAL obj = new AsignaturaDAL.AsignaturaDAL();
                obj.EliminarAsignatura(id);
                return true; // Retorna true si la eliminación fue exitosa.
            }
            catch (Exception)
            {
                return false; // Retorna false si ocurre alguna excepción.
            }
        }

        // Método para obtener una lista de todas las materias de la base de datos.
        public static List<Materia> SeleccionarTodos()
        {
            List<Materia> lista = new List<Materia>();
            try
            {
                // Crea una instancia de la capa de datos (DAL) y llama al método para seleccionar todas las materias.
                AsignaturaDAL.AsignaturaDAL obj = new AsignaturaDAL.AsignaturaDAL();
                lista = obj.SeleccionarTodosAsignatura();
                return lista; // Retorna la lista de materias obtenidas.
            }
            catch (Exception)
            {
                return null; // Retorna null si ocurre alguna excepción.
            }
        }

        // Método para seleccionar una única materia de la base de datos por su ID.
        public static Materia SeleccionarUno(int id)
        {
            Materia estudiante = new Materia();
            try
            {
                // Crea una instancia de la capa de datos (DAL) y llama al método para seleccionar una materia específica.
                AsignaturaDAL.AsignaturaDAL obj = new AsignaturaDAL.AsignaturaDAL();
                estudiante = obj.SeleccionarUnoAsignatura(id);
                return estudiante; // Retorna el objeto Materia encontrado.
            }
            catch (Exception)
            {
                return null; // Retorna null si ocurre alguna excepción.
            }
        }
    }
}

