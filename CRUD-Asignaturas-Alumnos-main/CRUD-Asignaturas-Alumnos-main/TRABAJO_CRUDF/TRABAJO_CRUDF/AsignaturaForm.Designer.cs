namespace TRABAJO_CRUDF
{
    partial class AsignaturaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignaturaForm));
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.txt_Codigoasignatura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Creditos = new System.Windows.Forms.TextBox();
            this.txt_NombreAsignatura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.trabajo_CrudDataSet = new TRABAJO_CRUDF.Trabajo_CrudDataSet();
            this.asignaturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asignaturasTableAdapter = new TRABAJO_CRUDF.Trabajo_CrudDataSetTableAdapters.AsignaturasTableAdapter();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_descargarasig = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajo_CrudDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Location = new System.Drawing.Point(76, 186);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(89, 32);
            this.btn_Guardar.TabIndex = 2;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_Borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Borrar.Location = new System.Drawing.Point(76, 224);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(89, 32);
            this.btn_Borrar.TabIndex = 4;
            this.btn_Borrar.Text = "Borrar";
            this.btn_Borrar.UseVisualStyleBackColor = false;
            this.btn_Borrar.Click += new System.EventHandler(this.btn_Borrar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar.Location = new System.Drawing.Point(171, 186);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(89, 32);
            this.btn_Modificar.TabIndex = 3;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // txt_Codigoasignatura
            // 
            this.txt_Codigoasignatura.Location = new System.Drawing.Point(128, 73);
            this.txt_Codigoasignatura.Name = "txt_Codigoasignatura";
            this.txt_Codigoasignatura.ReadOnly = true;
            this.txt_Codigoasignatura.Size = new System.Drawing.Size(100, 20);
            this.txt_Codigoasignatura.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Asignatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Asignatura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Créditos";
            // 
            // txt_Creditos
            // 
            this.txt_Creditos.Location = new System.Drawing.Point(128, 125);
            this.txt_Creditos.Name = "txt_Creditos";
            this.txt_Creditos.Size = new System.Drawing.Size(100, 20);
            this.txt_Creditos.TabIndex = 1;
            this.txt_Creditos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreditos_KeyPress);
            // 
            // txt_NombreAsignatura
            // 
            this.txt_NombreAsignatura.Location = new System.Drawing.Point(128, 99);
            this.txt_NombreAsignatura.Name = "txt_NombreAsignatura";
            this.txt_NombreAsignatura.Size = new System.Drawing.Size(100, 20);
            this.txt_NombreAsignatura.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(420, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "Inscripción de Asignaturas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(636, 260);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.DataSource = this.asignaturasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(266, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 174);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // trabajo_CrudDataSet
            // 
            this.trabajo_CrudDataSet.DataSetName = "Trabajo_CrudDataSet";
            this.trabajo_CrudDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asignaturasBindingSource
            // 
            this.asignaturasBindingSource.DataMember = "Asignaturas";
            this.asignaturasBindingSource.DataSource = this.trabajo_CrudDataSet;
            // 
            // asignaturasTableAdapter
            // 
            this.asignaturasTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CodigoAsignatura";
            this.dataGridViewTextBoxColumn4.HeaderText = "CodigoAsignatura";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NombreAsignatura";
            this.dataGridViewTextBoxColumn5.HeaderText = "NombreAsignatura";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Creditos";
            this.dataGridViewTextBoxColumn6.HeaderText = "Creditos";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // btn_descargarasig
            // 
            this.btn_descargarasig.BackColor = System.Drawing.Color.Gold;
            this.btn_descargarasig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_descargarasig.Location = new System.Drawing.Point(171, 224);
            this.btn_descargarasig.Name = "btn_descargarasig";
            this.btn_descargarasig.Size = new System.Drawing.Size(89, 32);
            this.btn_descargarasig.TabIndex = 13;
            this.btn_descargarasig.Text = "Descargar";
            this.btn_descargarasig.UseVisualStyleBackColor = false;
            this.btn_descargarasig.Click += new System.EventHandler(this.btn_descargarasig_Click);
            // 
            // AsignaturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 384);
            this.Controls.Add(this.btn_descargarasig);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_NombreAsignatura);
            this.Controls.Add(this.txt_Creditos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Codigoasignatura);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Borrar);
            this.Controls.Add(this.btn_Guardar);
            this.Name = "AsignaturaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AsignaturaForm";
            this.Load += new System.EventHandler(this.AsignaturaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajo_CrudDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Borrar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.TextBox txt_Codigoasignatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Creditos;
        private System.Windows.Forms.TextBox txt_NombreAsignatura;
    
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoAsignaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAsignaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditosDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Trabajo_CrudDataSet trabajo_CrudDataSet;
        private System.Windows.Forms.BindingSource asignaturasBindingSource;
        private Trabajo_CrudDataSetTableAdapters.AsignaturasTableAdapter asignaturasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btn_descargarasig;
    }
}