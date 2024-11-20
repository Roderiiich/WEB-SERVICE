using AsignaturaBOL;
using EstudiantesBOL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRABAJO_CRUDF
{
    public partial class AsignaturaForm : Form
    {
        public AsignaturaForm()
        {
            InitializeComponent();
        }


     

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_Codigoasignatura.Text, out int idAsignatura))
            {
                // Pide confirmación antes de eliminar el registro
                DialogResult confirmacion = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar esta asignatura?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {

                    bool resultado = AsignaturaBL.AsignaturaBL.Eliminar(idAsignatura);

                    if (resultado)
                    {
                        MessageBox.Show("Asignatura eliminada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatosAsignatura(); // Actualiza el DataGridView para reflejar los cambios
                        LimpiarCampos(); // Limpia los campos de entrada después de la eliminación
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar asignatura. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un Código de asignatura válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void AsignaturaForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'trabajo_CrudDataSet.Asignaturas' Puede moverla o quitarla según sea necesario.
            this.asignaturasTableAdapter.Fill(this.trabajo_CrudDataSet.Asignaturas);
            // TODO: esta línea de código carga datos en la tabla 'trabajo_CrudDataSetMARTESMALOO.Asignaturas' Puede moverla o quitarla según sea necesario.
   
            // TODO: esta línea de código carga datos en la tabla 'trabajo_CrudDataSetCASITA2.Asignaturas' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'trabajo_CrudDataSet.Asignaturas' Puede moverla o quitarla según sea necesario.

            // TODO: esta línea de código carga datos en la tabla 'trabajo_CrudDataSet.Asignaturas' Puede moverla o quitarla según sea necesario.
            //ACa va el diss

        }
        private void CargarDatosAsignatura()
        {
            //llenar el DataGridView de nuevo
            this.asignaturasTableAdapter.Fill(this.trabajo_CrudDataSet.Asignaturas);
            //DISSS
        }

        private void txtCreditos_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números y el carácter de control (backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela el ingreso del carácter
                MessageBox.Show("Solo se permiten números en este campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            // Validaciones de formato y requeridos
            if (string.IsNullOrWhiteSpace(txt_NombreAsignatura.Text))
            {
                MessageBox.Show("Falta ingresar el Nombre de asignatura", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_NombreAsignatura.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_Creditos.Text))
            {
                MessageBox.Show("Falta ingresar los creditos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Creditos.Focus();
                return;
            }
  


            // Crear la instancia de Estu y asignar los valores
            Materia nuevaAsignatura = new Materia
            {
                NombreAsignatura = txt_NombreAsignatura.Text,
                Creditos = Convert.ToInt32(txt_Creditos.Text)
             
            };



            bool resultado = AsignaturaBL.AsignaturaBL.Insertar(nuevaAsignatura);
            if (resultado)
            {
                MessageBox.Show("asignatura guardada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarDatosAsignatura();

            }
            else
            {
                MessageBox.Show("Error al guardar la asignatura. Verifique los datos e intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    



        // Método para limpiar los campos después de guardar
        private void LimpiarCampos()
        {
            txt_Codigoasignatura.Clear();
            txt_NombreAsignatura.Clear();
            txt_Creditos.Clear();
       
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            // Verifica que el ID del alumno esté cargado antes de modificar
            if (string.IsNullOrEmpty(txt_Codigoasignatura.Text))
            {
                MessageBox.Show("Seleccione una asignatura de la lista para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Crear un objeto Estu con los datos actualizados
                Materia AsignaturaModificada = new Materia
                {
                    CodigoAsignatura = Convert.ToInt32(txt_Codigoasignatura.Text),
                    NombreAsignatura = txt_NombreAsignatura.Text,
                    Creditos = Convert.ToInt32(txt_Creditos.Text)
            
                };

                // Llamar al método de actualización en la capa de lógica de negocios
                bool resultado = AsignaturaBL.AsignaturaBL.Modificar(AsignaturaModificada);

                // Verificar el resultado y mostrar mensajes
                if (resultado)
                {
                    MessageBox.Show("Asignatura modificada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatosAsignatura(); // Refrescar el DataGridView
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al modificar la Asignatura. Verifique los datos e intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];


                // Rellena los TextBox con los datos seleccionados
                txt_Codigoasignatura.Text = fila.Cells[0].Value?.ToString();
                txt_NombreAsignatura.Text = fila.Cells[1].Value?.ToString();
                txt_Creditos.Text = fila.Cells[2].Value?.ToString();
             
            }
        }

        private void btn_descargarasig_Click(object sender, EventArgs e)
        {
            try
            {
                AlumnosYAsignaturasWS.MIWSPERUCA ws = new AlumnosYAsignaturasWS.MIWSPERUCA();
                List<AlumnosYAsignaturasWS.Asignaturas> lista = new List<AlumnosYAsignaturasWS.Asignaturas>();
                var listaAsignatura = ws.ListarAsignatura();
                foreach (var asignaturas in listaAsignatura)
                {
                    // Sincronizar con la base de datos local
                    AsignaturaBL.AsignaturaBL.Insertar(new Materia
                    {
                        NombreAsignatura = asignaturas.NombreAsignatura,
                        Creditos = asignaturas.Creditos,
                        
                    });
                }
                CargarDatosAsignatura();
                MessageBox.Show("Datos descargados y sincronizados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al descargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}

