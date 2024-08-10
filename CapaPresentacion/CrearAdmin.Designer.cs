namespace CapaPresentacion
{
    partial class CrearAdmin
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
            button1 = new Button();
            Nombre = new TextBox();
            label1 = new Label();
            FechaNacimiento = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            Apellido = new TextBox();
            label4 = new Label();
            Correo = new TextBox();
            label5 = new Label();
            label6 = new Label();
            Clave = new TextBox();
            label7 = new Label();
            Departamento = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(54, 459);
            button1.Name = "button1";
            button1.Size = new Size(272, 37);
            button1.TabIndex = 0;
            button1.Text = "registrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Nombre
            // 
            Nombre.Location = new Point(54, 106);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(272, 23);
            Nombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(98, 18);
            label1.Name = "label1";
            label1.Size = new Size(192, 30);
            label1.TabIndex = 2;
            label1.Text = "Crear nuevo Admin";
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.Location = new Point(54, 352);
            FechaNacimiento.Name = "FechaNacimiento";
            FechaNacimiento.Size = new Size(272, 23);
            FechaNacimiento.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 79);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 143);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Apellido";
            // 
            // Apellido
            // 
            Apellido.Location = new Point(54, 170);
            Apellido.Name = "Apellido";
            Apellido.Size = new Size(272, 23);
            Apellido.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 209);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 8;
            label4.Text = "Correo";
            // 
            // Correo
            // 
            Correo.Location = new Point(54, 236);
            Correo.Name = "Correo";
            Correo.Size = new Size(272, 23);
            Correo.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 325);
            label5.Name = "label5";
            label5.Size = new Size(117, 15);
            label5.TabIndex = 9;
            label5.Text = "Fecha de nacimiento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 388);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 11;
            label6.Text = "Clave";
            // 
            // Clave
            // 
            Clave.Location = new Point(54, 415);
            Clave.Name = "Clave";
            Clave.Size = new Size(272, 23);
            Clave.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(54, 271);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 13;
            label7.Text = "Departamento";
            // 
            // Departamento
            // 
            Departamento.Location = new Point(54, 298);
            Departamento.Name = "Departamento";
            Departamento.Size = new Size(272, 23);
            Departamento.TabIndex = 12;
            // 
            // CrearAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 508);
            Controls.Add(label7);
            Controls.Add(Departamento);
            Controls.Add(label6);
            Controls.Add(Clave);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Correo);
            Controls.Add(label3);
            Controls.Add(Apellido);
            Controls.Add(label2);
            Controls.Add(FechaNacimiento);
            Controls.Add(label1);
            Controls.Add(Nombre);
            Controls.Add(button1);
            Name = "CrearAdmin";
            Text = "CrearAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox Nombre;
        private Label label1;
        private DateTimePicker FechaNacimiento;
        private Label label2;
        private Label label3;
        private TextBox Apellido;
        private Label label4;
        private TextBox Correo;
        private Label label5;
        private Label label6;
        private TextBox Clave;
        private Label label7;
        private TextBox Departamento;
    }
}