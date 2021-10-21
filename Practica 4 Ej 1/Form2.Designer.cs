namespace Practica_4_Ej_1
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txb_Edad = new System.Windows.Forms.TextBox();
            this.txb_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Edad = new System.Windows.Forms.Label();
            this.lbl_Sexo = new System.Windows.Forms.Label();
            this.txb_Sexo = new System.Windows.Forms.TextBox();
            this.btn_Estudiante = new System.Windows.Forms.Button();
            this.btn_Empleado = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.Location = new System.Drawing.Point(334, 232);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Empleado);
            this.groupBox1.Controls.Add(this.btn_Estudiante);
            this.groupBox1.Controls.Add(this.lbl_Sexo);
            this.groupBox1.Controls.Add(this.txb_Sexo);
            this.groupBox1.Controls.Add(this.lbl_Edad);
            this.groupBox1.Controls.Add(this.lbl_Nombre);
            this.groupBox1.Controls.Add(this.txb_Nombre);
            this.groupBox1.Controls.Add(this.txb_Edad);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 214);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // txb_Edad
            // 
            this.txb_Edad.Location = new System.Drawing.Point(119, 82);
            this.txb_Edad.Name = "txb_Edad";
            this.txb_Edad.Size = new System.Drawing.Size(182, 20);
            this.txb_Edad.TabIndex = 0;
            // 
            // txb_Nombre
            // 
            this.txb_Nombre.Location = new System.Drawing.Point(119, 34);
            this.txb_Nombre.Name = "txb_Nombre";
            this.txb_Nombre.Size = new System.Drawing.Size(182, 20);
            this.txb_Nombre.TabIndex = 1;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(69, 37);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 2;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.AutoSize = true;
            this.lbl_Edad.Location = new System.Drawing.Point(78, 85);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(32, 13);
            this.lbl_Edad.TabIndex = 3;
            this.lbl_Edad.Text = "Edad";
            // 
            // lbl_Sexo
            // 
            this.lbl_Sexo.AutoSize = true;
            this.lbl_Sexo.Location = new System.Drawing.Point(78, 131);
            this.lbl_Sexo.Name = "lbl_Sexo";
            this.lbl_Sexo.Size = new System.Drawing.Size(31, 13);
            this.lbl_Sexo.TabIndex = 5;
            this.lbl_Sexo.Text = "Sexo";
            // 
            // txb_Sexo
            // 
            this.txb_Sexo.Location = new System.Drawing.Point(119, 128);
            this.txb_Sexo.Name = "txb_Sexo";
            this.txb_Sexo.Size = new System.Drawing.Size(182, 20);
            this.txb_Sexo.TabIndex = 4;
            // 
            // btn_Estudiante
            // 
            this.btn_Estudiante.BackColor = System.Drawing.Color.DimGray;
            this.btn_Estudiante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_Estudiante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_Estudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Estudiante.ForeColor = System.Drawing.Color.White;
            this.btn_Estudiante.Location = new System.Drawing.Point(113, 175);
            this.btn_Estudiante.Name = "btn_Estudiante";
            this.btn_Estudiante.Size = new System.Drawing.Size(75, 23);
            this.btn_Estudiante.TabIndex = 6;
            this.btn_Estudiante.Text = "Estudiante";
            this.btn_Estudiante.UseVisualStyleBackColor = false;
            // 
            // btn_Empleado
            // 
            this.btn_Empleado.BackColor = System.Drawing.Color.DimGray;
            this.btn_Empleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_Empleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_Empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Empleado.ForeColor = System.Drawing.Color.White;
            this.btn_Empleado.Location = new System.Drawing.Point(218, 174);
            this.btn_Empleado.Name = "btn_Empleado";
            this.btn_Empleado.Size = new System.Drawing.Size(75, 23);
            this.btn_Empleado.TabIndex = 7;
            this.btn_Empleado.Text = "Empleado";
            this.btn_Empleado.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(424, 269);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Persona";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Controls.SetChildIndex(this.btn_Salir, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Edad;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox txb_Nombre;
        private System.Windows.Forms.TextBox txb_Edad;
        private System.Windows.Forms.Label lbl_Sexo;
        private System.Windows.Forms.TextBox txb_Sexo;
        private System.Windows.Forms.Button btn_Empleado;
        private System.Windows.Forms.Button btn_Estudiante;
    }
}
