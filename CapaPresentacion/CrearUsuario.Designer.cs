namespace CapaPresentacion
{
    partial class CrearUsuario
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
            label1 = new Label();
            Matricula = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            Nombre = new TextBox();
            label4 = new Label();
            Correo = new TextBox();
            label5 = new Label();
            Carrera = new TextBox();
            label6 = new Label();
            Clave = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(124, 28);
            label1.Name = "label1";
            label1.Size = new Size(183, 25);
            label1.TabIndex = 0;
            label1.Text = "Crear nuevo usuario";
            // 
            // Matricula
            // 
            Matricula.Location = new Point(61, 109);
            Matricula.Name = "Matricula";
            Matricula.Size = new Size(296, 23);
            Matricula.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(61, 384);
            button1.Name = "button1";
            button1.Size = new Size(296, 41);
            button1.TabIndex = 2;
            button1.Text = "registrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 91);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Matricula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 146);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "Nombre";
            // 
            // Nombre
            // 
            Nombre.Location = new Point(61, 164);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(296, 23);
            Nombre.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 205);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 7;
            label4.Text = "Correo";
            // 
            // Correo
            // 
            Correo.Location = new Point(61, 223);
            Correo.Name = "Correo";
            Correo.Size = new Size(296, 23);
            Correo.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 259);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 9;
            label5.Text = "Carrera";
            // 
            // Carrera
            // 
            Carrera.Location = new Point(61, 277);
            Carrera.Name = "Carrera";
            Carrera.Size = new Size(296, 23);
            Carrera.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 315);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 11;
            label6.Text = "Clave";
            // 
            // Clave
            // 
            Clave.Location = new Point(61, 333);
            Clave.Name = "Clave";
            Clave.Size = new Size(296, 23);
            Clave.TabIndex = 10;
            // 
            // CrearUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 450);
            Controls.Add(label6);
            Controls.Add(Clave);
            Controls.Add(label5);
            Controls.Add(Carrera);
            Controls.Add(label4);
            Controls.Add(Correo);
            Controls.Add(label3);
            Controls.Add(Nombre);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(Matricula);
            Controls.Add(label1);
            Name = "CrearUsuario";
            Text = "CrearUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Matricula;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox Nombre;
        private Label label4;
        private TextBox Correo;
        private Label label5;
        private TextBox Carrera;
        private Label label6;
        private TextBox Clave;
    }
}