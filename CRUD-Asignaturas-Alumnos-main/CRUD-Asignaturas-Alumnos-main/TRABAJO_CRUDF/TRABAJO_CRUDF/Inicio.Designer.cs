namespace TRABAJO_CRUDF
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.btn_Inscribiralumno = new System.Windows.Forms.Button();
            this.btn_Inscribirasignatura = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Inscribiralumno
            // 
            this.btn_Inscribiralumno.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_Inscribiralumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inscribiralumno.Location = new System.Drawing.Point(162, 287);
            this.btn_Inscribiralumno.Name = "btn_Inscribiralumno";
            this.btn_Inscribiralumno.Size = new System.Drawing.Size(180, 41);
            this.btn_Inscribiralumno.TabIndex = 0;
            this.btn_Inscribiralumno.Text = "Agregar Alumnos";
            this.btn_Inscribiralumno.UseVisualStyleBackColor = false;
            this.btn_Inscribiralumno.Click += new System.EventHandler(this.btn_Inscribiralumno_Click);
            // 
            // btn_Inscribirasignatura
            // 
            this.btn_Inscribirasignatura.BackColor = System.Drawing.Color.Plum;
            this.btn_Inscribirasignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inscribirasignatura.Location = new System.Drawing.Point(162, 334);
            this.btn_Inscribirasignatura.Name = "btn_Inscribirasignatura";
            this.btn_Inscribirasignatura.Size = new System.Drawing.Size(180, 41);
            this.btn_Inscribirasignatura.TabIndex = 1;
            this.btn_Inscribirasignatura.Text = "Agregar Asignaturas";
            this.btn_Inscribirasignatura.UseVisualStyleBackColor = false;
            this.btn_Inscribirasignatura.Click += new System.EventHandler(this.btn_Inscribirasignatura_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "¿Qué deseas hacer?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Carlos Cadena - Rodrigo Cortés";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(162, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(485, 434);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Inscribirasignatura);
            this.Controls.Add(this.btn_Inscribiralumno);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Inscribiralumno;
        private System.Windows.Forms.Button btn_Inscribirasignatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

