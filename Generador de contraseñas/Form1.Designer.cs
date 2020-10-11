namespace Generador_de_contraseñas
{
    partial class Form1
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
            this.list_Contraseñas = new System.Windows.Forms.ListBox();
            this.Contador_caracteres = new System.Windows.Forms.NumericUpDown();
            this.check_mayusculas = new System.Windows.Forms.CheckBox();
            this.check_caracteres = new System.Windows.Forms.CheckBox();
            this.check_simbolos = new System.Windows.Forms.CheckBox();
            this.btn_generar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Contador_caracteres)).BeginInit();
            this.SuspendLayout();
            // 
            // list_Contraseñas
            // 
            this.list_Contraseñas.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_Contraseñas.FormattingEnabled = true;
            this.list_Contraseñas.ItemHeight = 23;
            this.list_Contraseñas.Location = new System.Drawing.Point(12, 18);
            this.list_Contraseñas.Name = "list_Contraseñas";
            this.list_Contraseñas.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.list_Contraseñas.Size = new System.Drawing.Size(379, 418);
            this.list_Contraseñas.TabIndex = 0;
            this.list_Contraseñas.SelectedIndexChanged += new System.EventHandler(this.list_Contraseñas_SelectedIndexChanged);
            // 
            // Contador_caracteres
            // 
            this.Contador_caracteres.Location = new System.Drawing.Point(406, 91);
            this.Contador_caracteres.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.Contador_caracteres.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Contador_caracteres.Name = "Contador_caracteres";
            this.Contador_caracteres.Size = new System.Drawing.Size(205, 22);
            this.Contador_caracteres.TabIndex = 1;
            this.Contador_caracteres.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // check_mayusculas
            // 
            this.check_mayusculas.AutoSize = true;
            this.check_mayusculas.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_mayusculas.Location = new System.Drawing.Point(406, 129);
            this.check_mayusculas.Name = "check_mayusculas";
            this.check_mayusculas.Size = new System.Drawing.Size(150, 22);
            this.check_mayusculas.TabIndex = 2;
            this.check_mayusculas.Text = "Usar Mayúsculas";
            this.check_mayusculas.UseVisualStyleBackColor = true;
            // 
            // check_caracteres
            // 
            this.check_caracteres.AutoSize = true;
            this.check_caracteres.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_caracteres.Location = new System.Drawing.Point(406, 170);
            this.check_caracteres.Name = "check_caracteres";
            this.check_caracteres.Size = new System.Drawing.Size(150, 22);
            this.check_caracteres.TabIndex = 3;
            this.check_caracteres.Text = "Usar Caracteres";
            this.check_caracteres.UseVisualStyleBackColor = true;
            // 
            // check_simbolos
            // 
            this.check_simbolos.AutoSize = true;
            this.check_simbolos.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_simbolos.Location = new System.Drawing.Point(406, 212);
            this.check_simbolos.Name = "check_simbolos";
            this.check_simbolos.Size = new System.Drawing.Size(134, 22);
            this.check_simbolos.TabIndex = 4;
            this.check_simbolos.Text = "Usar Simbolos";
            this.check_simbolos.UseVisualStyleBackColor = true;
            // 
            // btn_generar
            // 
            this.btn_generar.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar.Location = new System.Drawing.Point(428, 373);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(183, 53);
            this.btn_generar.TabIndex = 5;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "No. Caracteres";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.check_simbolos);
            this.Controls.Add(this.check_caracteres);
            this.Controls.Add(this.check_mayusculas);
            this.Controls.Add(this.Contador_caracteres);
            this.Controls.Add(this.list_Contraseñas);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Contador_caracteres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_Contraseñas;
        private System.Windows.Forms.NumericUpDown Contador_caracteres;
        private System.Windows.Forms.CheckBox check_mayusculas;
        private System.Windows.Forms.CheckBox check_caracteres;
        private System.Windows.Forms.CheckBox check_simbolos;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Label label1;
    }
}

