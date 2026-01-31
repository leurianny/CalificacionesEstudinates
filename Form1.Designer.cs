namespace Ejercicio7
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.textBoxN1 = new System.Windows.Forms.TextBox();
            this.textBoxN2 = new System.Windows.Forms.TextBox();
            this.textBoxN3 = new System.Windows.Forms.TextBox();
            this.textBoxN4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelNC = new System.Windows.Forms.Label();
            this.buttonEnviar2 = new System.Windows.Forms.Button();
            this.textBoxCompletivo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelNE = new System.Windows.Forms.Label();
            this.buttonEnviar3 = new System.Windows.Forms.Button();
            this.textBoxExtra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonEnviar);
            this.groupBox1.Controls.Add(this.textBoxN1);
            this.groupBox1.Controls.Add(this.textBoxN2);
            this.groupBox1.Controls.Add(this.textBoxN3);
            this.groupBox1.Controls.Add(this.textBoxN4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar las notas ";
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(42, 159);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(119, 23);
            this.buttonEnviar.TabIndex = 5;
            this.buttonEnviar.Text = "Calcular Promedio";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // textBoxN1
            // 
            this.textBoxN1.Location = new System.Drawing.Point(73, 26);
            this.textBoxN1.Name = "textBoxN1";
            this.textBoxN1.Size = new System.Drawing.Size(100, 20);
            this.textBoxN1.TabIndex = 1;
            // 
            // textBoxN2
            // 
            this.textBoxN2.Location = new System.Drawing.Point(73, 52);
            this.textBoxN2.Name = "textBoxN2";
            this.textBoxN2.Size = new System.Drawing.Size(100, 20);
            this.textBoxN2.TabIndex = 2;
            // 
            // textBoxN3
            // 
            this.textBoxN3.Location = new System.Drawing.Point(73, 81);
            this.textBoxN3.Name = "textBoxN3";
            this.textBoxN3.Size = new System.Drawing.Size(100, 20);
            this.textBoxN3.TabIndex = 3;
            // 
            // textBoxN4
            // 
            this.textBoxN4.Location = new System.Drawing.Point(73, 111);
            this.textBoxN4.Name = "textBoxN4";
            this.textBoxN4.Size = new System.Drawing.Size(100, 20);
            this.textBoxN4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nota1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nota3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nota4";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelNC);
            this.groupBox2.Controls.Add(this.buttonEnviar2);
            this.groupBox2.Controls.Add(this.textBoxCompletivo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(258, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 126);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Examen Completivo";
            this.groupBox2.Visible = false;
            // 
            // labelNC
            // 
            this.labelNC.AutoSize = true;
            this.labelNC.Location = new System.Drawing.Point(6, 110);
            this.labelNC.Name = "labelNC";
            this.labelNC.Size = new System.Drawing.Size(88, 13);
            this.labelNC.TabIndex = 3;
            this.labelNC.Text = "Nota Completivo:";
            this.labelNC.Visible = false;
            this.labelNC.Click += new System.EventHandler(this.label6_Click);
            // 
            // buttonEnviar2
            // 
            this.buttonEnviar2.Location = new System.Drawing.Point(27, 71);
            this.buttonEnviar2.Name = "buttonEnviar2";
            this.buttonEnviar2.Size = new System.Drawing.Size(138, 23);
            this.buttonEnviar2.TabIndex = 2;
            this.buttonEnviar2.Text = "Calcular Completivo";
            this.buttonEnviar2.UseVisualStyleBackColor = true;
            this.buttonEnviar2.Click += new System.EventHandler(this.buttonEnviar2_Click);
            // 
            // textBoxCompletivo
            // 
            this.textBoxCompletivo.Location = new System.Drawing.Point(94, 29);
            this.textBoxCompletivo.Name = "textBoxCompletivo";
            this.textBoxCompletivo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCompletivo.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nota Completivo:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelNE);
            this.groupBox3.Controls.Add(this.buttonEnviar3);
            this.groupBox3.Controls.Add(this.textBoxExtra);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(252, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 125);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Examen Extraordinario";
            this.groupBox3.Visible = false;
            // 
            // labelNE
            // 
            this.labelNE.AutoSize = true;
            this.labelNE.Location = new System.Drawing.Point(12, 99);
            this.labelNE.Name = "labelNE";
            this.labelNE.Size = new System.Drawing.Size(100, 13);
            this.labelNE.TabIndex = 3;
            this.labelNE.Text = "Nota Extraordinario:";
            this.labelNE.Visible = false;
            // 
            // buttonEnviar3
            // 
            this.buttonEnviar3.Location = new System.Drawing.Point(33, 61);
            this.buttonEnviar3.Name = "buttonEnviar3";
            this.buttonEnviar3.Size = new System.Drawing.Size(143, 23);
            this.buttonEnviar3.TabIndex = 3;
            this.buttonEnviar3.Text = "Calcular Extraordinario";
            this.buttonEnviar3.UseVisualStyleBackColor = true;
            this.buttonEnviar3.Click += new System.EventHandler(this.buttonEnviar3_Click);
            // 
            // textBoxExtra
            // 
            this.textBoxExtra.Location = new System.Drawing.Point(103, 26);
            this.textBoxExtra.Name = "textBoxExtra";
            this.textBoxExtra.Size = new System.Drawing.Size(100, 20);
            this.textBoxExtra.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nota Extraordinario:";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(40, 242);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(54, 13);
            this.labelN.TabIndex = 3;
            this.labelN.Text = "Promedio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nota Completivo:\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Extraordinario:";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.ForeColor = System.Drawing.Color.Black;
            this.labelEstado.Location = new System.Drawing.Point(40, 324);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(40, 13);
            this.labelEstado.TabIndex = 6;
            this.labelEstado.Text = "Estado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(383, 342);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 8;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ejecicio7";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.TextBox textBoxN1;
        private System.Windows.Forms.TextBox textBoxN2;
        private System.Windows.Forms.TextBox textBoxN3;
        private System.Windows.Forms.TextBox textBoxN4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelNC;
        private System.Windows.Forms.Button buttonEnviar2;
        private System.Windows.Forms.TextBox textBoxCompletivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelNE;
        private System.Windows.Forms.Button buttonEnviar3;
        private System.Windows.Forms.TextBox textBoxExtra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSalir;
    }
}

