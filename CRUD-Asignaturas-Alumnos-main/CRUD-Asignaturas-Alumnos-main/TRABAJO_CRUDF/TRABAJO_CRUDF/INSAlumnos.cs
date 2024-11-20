using AsignaturaBOL;
using EstudiantesBL;
using EstudiantesBOL;
using EstudiantesDAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRABAJO_CRUDF.AlumnosYAsignaturasWS;

namespace TRABAJO_CRUDF
{
    public partial class INSAlumnos : Form
    {
        public INSAlumnos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void INSAlumnos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'trabajo_CrudDataSet.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.trabajo_CrudDataSet.Alumnos);
            // TODO: esta línea de código carga datos en la tabla 'trabajo_CrudDataSetMARTESMALOO.Alumnos' Puede moverla o quitarla según sea necesario.
           
            // TODO: esta línea de código carga datos en la tabla 'trabajo_CrudDataSetCASITA2.Alumnos' Puede moverla o quitarla según sea necesario.
         
            // TODO: esta línea de código carga datos en la tabla 'trabajo_CrudDataSet.Alumnos' Puede moverla o quitarla según sea necesario.
          
            // TODO: esta línea de código carga datos en la tabla 'trabajo_CrudDataSet.Alumnos' Puede moverla o quitarla según sea necesario.
            //ACA VA EL THIS
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validaciones de formato y requeridos
            if (string.IsNullOrWhiteSpace(txt_Nombre.Text))
            {
                MessageBox.Show("Falta ingresar el Nombre", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Nombre.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_ApellidoPAt.Text))
            {
                MessageBox.Show("Falta ingresar el Apellido Paterno", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_ApellidoPAt.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_ApellidoMat.Text))
            {
                MessageBox.Show("Falta ingresar el Apellido Materno", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_ApellidoMat.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_Email.Text))
            {
                MessageBox.Show("Falta ingresar el Email", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Email.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_Matricula.Text))
            {
                MessageBox.Show("Falta ingresar el N° de Matrícula", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Matricula.Focus();
                return;
            }

            // Crear la instancia de Estudiantes que en este caso es Estu y asignar los valores
            Estu nuevoAlumno = new Estu
            {
                Nombre = txt_Nombre.Text,
                ApellidoPAt = txt_ApellidoPAt.Text,
                ApellidoMat = txt_ApellidoMat.Text,
                Email = txt_Email.Text,
                N_Matricula = txt_Matricula.Text
            };



            bool resultado = EstudiantesBL.EstudiantesBL.Insertar(nuevoAlumno);
            if (resultado)
            {
                MessageBox.Show("Alumno guardado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarDatosAlumnos();
               AlumnosYAsignaturasWS.MIWSPERUCA ws = new AlumnosYAsignaturasWS.MIWSPERUCA();    
                ws.GuardarAlumnos(txt_Nombre.Text,txt_ApellidoPAt.Text, txt_ApellidoMat.Text, txt_Email.Text, txt_Matricula.Text);

            }
            else
            {
                MessageBox.Show("Error al guardar el alumno. Verifique los datos e intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        // Método para limpiar los campos después de guardar
        private void LimpiarCampos()
        {
            txt_IDAlumno.Clear();
            txt_Nombre.Clear();
            txt_ApellidoPAt.Clear();
            txt_ApellidoMat.Clear();
            txt_Email.Clear();
            txt_Matricula.Clear();
        }

        private void CargarDatosAlumnos()
        {
            //método para llenar el DataGridView
            this.alumnosTableAdapter.Fill(this.trabajo_CrudDataSet.Alumnos);
            //ACA VA OTRO THIS
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private int alumnoIdSeleccionado;





        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            // Verifica que el ID del alumno esté cargado antes de modificar
            if (string.IsNullOrEmpty(txt_IDAlumno.Text))
            {
                MessageBox.Show("Seleccione un alumno de la lista para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Crear un objeto Estu con los datos actualizados
                Estu AlumnoModificado = new Estu
                {
                    IDAlumnos = Convert.ToInt32(txt_IDAlumno.Text),
                    Nombre = txt_Nombre.Text,
                    ApellidoPAt = txt_ApellidoPAt.Text,
                    ApellidoMat = txt_ApellidoMat.Text,
                    Email = txt_Email.Text,
                    N_Matricula = txt_Matricula.Text

                };

                // Llamar al método de actualización en la capa de lógica de negocios
                bool resultado = EstudiantesBL.EstudiantesBL.Modificar(AlumnoModificado);

                // Verificar el resultado y mostrar mensajes
                if (resultado)
                {
                    MessageBox.Show("Alumno modificada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatosAlumnos(); // Refrescar el DataGridView
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al modificar el alumno. Verifique los datos e intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }







        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             if (e.RowIndex >= 0)
             {



                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];


                // Rellena los TextBox con los datos seleccionados
                txt_IDAlumno.Text = fila.Cells[0].Value?.ToString();
                txt_Nombre.Text = fila.Cells[1].Value?.ToString();
                txt_ApellidoPAt.Text = fila.Cells[2].Value?.ToString();
                txt_ApellidoMat.Text = fila.Cells[3].Value?.ToString();
                txt_Email.Text = fila.Cells[4].Value?.ToString();
                txt_Matricula.Text = fila.Cells[5].Value?.ToString();
                

            }

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Itera a través de cada fila seleccionada en el DataGridView
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    // Obtiene el ID del alumno de la primera celda de la fila seleccionada
                    int idAlumno = (int)row.Cells[0].Value;

                    // Llama a la capa de negocio para eliminar el alumno
                    bool eliminado = EstudiantesBL.EstudiantesBL.Eliminar(idAlumno);

                    // Si el alumno no se elimina correctamente, muestra un mensaje
                    if (!eliminado)
                    {
                        MessageBox.Show($"Error al eliminar el alumno con ID {idAlumno}");
                        
                        LimpiarCampos();
                    }
                }

                // Muestra un mensaje de confirmación si todos los alumnos seleccionados se eliminaron correctamente
                MessageBox.Show("Alumnos eliminados exitosamente!");

                // Actualiza el DataGridView para reflejar los cambios
                CargarDatosAlumnos();
                LimpiarCampos();


            }
            else
            {
                // Muestra un mensaje si no hay filas seleccionadas
                MessageBox.Show("Por favor, selecciona al menos una fila para eliminar.");
                CargarDatosAlumnos();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_Email_Leave(object sender, EventArgs e)
        {
            // Expresión regular para validar formato de correo electrónico
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(txt_Email.Text, pattern))
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Email.Focus();
            }
        }

        private void txt_Matricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Matricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela el ingreso del carácter
                MessageBox.Show("Solo se permiten números en este campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

  

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {



                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];


                // Rellena los TextBox con los datos seleccionados
                txt_IDAlumno.Text = fila.Cells[0].Value?.ToString();
                txt_Nombre.Text = fila.Cells[1].Value?.ToString();
                txt_ApellidoPAt.Text = fila.Cells[2].Value?.ToString();
                txt_ApellidoMat.Text = fila.Cells[3].Value?.ToString();
                txt_Email.Text = fila.Cells[4].Value?.ToString();
                txt_Matricula.Text = fila.Cells[5].Value?.ToString();


            }
        }
       
        private void btn_descargar_Click(object sender, EventArgs e)
        {
            try
            {
                AlumnosYAsignaturasWS.MIWSPERUCA ws = new AlumnosYAsignaturasWS.MIWSPERUCA();
                List<AlumnosYAsignaturasWS.Alumnos> lista = new List<AlumnosYAsignaturasWS.Alumnos>();
                var listaAlumnos = ws.Listar();
                foreach (var alumno in listaAlumnos)
                {
                    // Sincronizar con la base de datos local
                    EstudiantesBL.EstudiantesBL.Insertar(new Estu
                    {
                        Nombre = alumno.Nombre,
                        ApellidoPAt = alumno.ApellidoPAt,
                        ApellidoMat = alumno.ApellidoMat,
                        Email = alumno.Email,
                        N_Matricula = alumno.N_Matricula
                    });
                }
                CargarDatosAlumnos();
                MessageBox.Show("Datos descargados y sincronizados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al descargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
    
    

