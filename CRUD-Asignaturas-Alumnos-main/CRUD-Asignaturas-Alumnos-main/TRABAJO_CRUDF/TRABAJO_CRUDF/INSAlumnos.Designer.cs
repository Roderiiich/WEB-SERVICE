namespace TRABAJO_CRUDF
{
    partial class INSAlumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_ApellidoPAt = new System.Windows.Forms.TextBox();
            this.txt_ApellidoMat = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Matricula = new System.Windows.Forms.TextBox();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.txt_IDAlumno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_descargar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.trabajo_CrudDataSet = new TRABAJO_CRUDF.Trabajo_CrudDataSet();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnosTableAdapter = new TRABAJO_CRUDF.Trabajo_CrudDataSetTableAdapters.AlumnosTableAdapter();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajo_CrudDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(71, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(13, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido Paterno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(10, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido Materno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(89, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(38, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "N° Matricula";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(145, 149);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 0;
            // 
            // txt_ApellidoPAt
            // 
            this.txt_ApellidoPAt.Location = new System.Drawing.Point(145, 175);
            this.txt_ApellidoPAt.Name = "txt_ApellidoPAt";
            this.txt_ApellidoPAt.Size = new System.Drawing.Size(100, 20);
            this.txt_ApellidoPAt.TabIndex = 1;
            // 
            // txt_ApellidoMat
            // 
            this.txt_ApellidoMat.Location = new System.Drawing.Point(145, 205);
            this.txt_ApellidoMat.Name = "txt_ApellidoMat";
            this.txt_ApellidoMat.Size = new System.Drawing.Size(100, 20);
            this.txt_ApellidoMat.TabIndex = 2;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(145, 231);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(100, 20);
            this.txt_Email.TabIndex = 3;
            this.txt_Email.Leave += new System.EventHandler(this.txt_Email_Leave);
            // 
            // txt_Matricula
            // 
            this.txt_Matricula.Location = new System.Drawing.Point(145, 257);
            this.txt_Matricula.Name = "txt_Matricula";
            this.txt_Matricula.Size = new System.Drawing.Size(100, 20);
            this.txt_Matricula.TabIndex = 4;
            this.txt_Matricula.TextChanged += new System.EventHandler(this.txt_Matricula_TextChanged);
            this.txt_Matricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Matricula_KeyPress);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.PaleGreen;
            this.Btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.Location = new System.Drawing.Point(272, 352);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(92, 33);
            this.Btn_guardar.TabIndex = 5;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar.Location = new System.Drawing.Point(370, 352);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(89, 33);
            this.btn_Modificar.TabIndex = 6;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.Salmon;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.Location = new System.Drawing.Point(465, 352);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 33);
            this.btn_Eliminar.TabIndex = 7;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // txt_IDAlumno
            // 
            this.txt_IDAlumno.Location = new System.Drawing.Point(145, 123);
            this.txt_IDAlumno.Name = "txt_IDAlumno";
            this.txt_IDAlumno.ReadOnly = true;
            this.txt_IDAlumno.Size = new System.Drawing.Size(100, 20);
            this.txt_IDAlumno.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "IDAlumno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(351, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(340, 33);
            this.label8.TabIndex = 19;
            this.label8.Text = "Inscripción de Alumnos";
            // 
            // btn_descargar
            // 
            this.btn_descargar.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_descargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_descargar.Location = new System.Drawing.Point(546, 352);
            this.btn_descargar.Name = "btn_descargar";
            this.btn_descargar.Size = new System.Drawing.Size(92, 33);
            this.btn_descargar.TabIndex = 22;
            this.btn_descargar.Text = "Descargar";
            this.btn_descargar.UseVisualStyleBackColor = false;
            this.btn_descargar.Click += new System.EventHandler(this.btn_descargar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.dataGridView1.DataSource = this.alumnosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(272, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 210);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // trabajo_CrudDataSet
            // 
            this.trabajo_CrudDataSet.DataSetName = "Trabajo_CrudDataSet";
            this.trabajo_CrudDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "Alumnos";
            this.alumnosBindingSource.DataSource = this.trabajo_CrudDataSet;
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "IDAlumnos";
            this.dataGridViewTextBoxColumn12.HeaderText = "IDAlumnos";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn13.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "ApellidoPAt";
            this.dataGridViewTextBoxColumn14.HeaderText = "ApellidoPAt";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "ApellidoMat";
            this.dataGridViewTextBoxColumn15.HeaderText = "ApellidoMat";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn16.HeaderText = "Email";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "N_Matricula";
            this.dataGridViewTextBoxColumn17.HeaderText = "N_Matricula";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // INSAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(941, 408);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_descargar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_IDAlumno);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.txt_Matricula);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_ApellidoMat);
            this.Controls.Add(this.txt_ApellidoPAt);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "INSAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INSAlumnos";
            this.Load += new System.EventHandler(this.INSAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajo_CrudDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_ApellidoPAt;
        private System.Windows.Forms.TextBox txt_ApellidoMat;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Matricula;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAlumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoMatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nMatriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Btn_guardar;
 
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAlumnosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.TextBox txt_IDAlumno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
     
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button btn_descargar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Trabajo_CrudDataSet trabajo_CrudDataSet;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private Trabajo_CrudDataSetTableAdapters.AlumnosTableAdapter alumnosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
    }
}