using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CRUD_PEROWS
{
    /// <summary>
    /// Descripción breve de MIWSPERUCA
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class MIWSPERUCA : System.Web.Services.WebService
    {

        [WebMethod]
        public bool GuardarAlumnos(     string Nombre, 
         string ApellidoPAt, 
        string ApellidoMat, 
         string Email,
        string N_Matricula )
        {

            try
            {
                Trabajo_Crud_RemotoEntitiesmiercoles ctx = new Trabajo_Crud_RemotoEntitiesmiercoles();
                Alumnos alumnos = new Alumnos();
                alumnos.Nombre = Nombre;
                alumnos.ApellidoPAt = ApellidoPAt;
                alumnos.ApellidoMat = ApellidoMat;
                alumnos.Email = Email;
                alumnos.N_Matricula = N_Matricula;
                ctx.Alumnos.Add(alumnos);
                ctx.SaveChanges();

            }
            catch (Exception)
            {

                return false;
            }
            return true;
           

        }
        [WebMethod]
        public bool GuardarAsignaturas(string NombreAsignatura,
        int Creditos
       )
        {

            try
            {
                Trabajo_Crud_RemotoEntitiesmiercoles ctx = new Trabajo_Crud_RemotoEntitiesmiercoles();
                Asignaturas asignaturas = new Asignaturas();
                asignaturas.NombreAsignatura = NombreAsignatura;
                asignaturas.Creditos = Creditos;
               
                ctx.Asignaturas.Add(asignaturas);
                ctx.SaveChanges();

            }
            catch (Exception)
            {

                return false;
            }
            return true;


        }
        [WebMethod]
        public List<Alumnos> Listar()
        {
            Trabajo_Crud_RemotoEntitiesmiercoles ctx = new Trabajo_Crud_RemotoEntitiesmiercoles();
           return ctx.Alumnos.ToList();
        }
        [WebMethod]
        public List<Asignaturas> ListarAsignatura()
        {
            Trabajo_Crud_RemotoEntitiesmiercoles ctx = new Trabajo_Crud_RemotoEntitiesmiercoles();
            return ctx.Asignaturas.ToList();
        }
    }
}
